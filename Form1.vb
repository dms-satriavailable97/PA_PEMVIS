Imports MySqlConnector

Public Class Form1

    Private dtLayanan As DataTable

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        IsiComboLayanan()
        Kosongkan()
    End Sub

    Sub TampilData()
        dgvJoki.DataSource = TampilJoki()
    End Sub

    Sub IsiComboLayanan()
        dtLayanan = GetLayananForCombo()
        cmbLayanan.DataSource = dtLayanan
        cmbLayanan.DisplayMember = "nama_layanan"
        cmbLayanan.ValueMember = "id_layanan"
        cmbLayanan.SelectedIndex = -1
    End Sub

    Sub Kosongkan()
        txtUID.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtDetail.Clear()
        cmbLayanan.SelectedIndex = -1
        cmbKesulitan.Items.Clear()
        cmbKesulitan.SelectedIndex = -1
        txtUID.Enabled = True
        lblHarga.Visible = False
        ErrorProvider1.Clear()
    End Sub

    Private Function HitungTotal() As Integer
        Dim row As DataRowView = cmbLayanan.SelectedItem
        Dim idLay As String = row("id_layanan").ToString()
        Dim dtLay As DataTable = TampilLayanan()
        Dim hargaDasar As Integer = 0

        For Each r As DataRow In dtLay.Rows
            If r("id_layanan").ToString() = idLay Then
                hargaDasar = Convert.ToInt32(r("harga_dasar"))
            End If
        Next

        Dim sulit As Integer = cmbKesulitan.SelectedIndex + 1
        Return hargaDasar * sulit
    End Function

    Private Sub cmbLayanan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLayanan.SelectedIndexChanged
        cmbKesulitan.Items.Clear()
        cmbKesulitan.SelectedIndex = -1

        If cmbLayanan.SelectedIndex = -1 Then Exit Sub

        Dim selectedRow As DataRowView = cmbLayanan.SelectedItem
        Dim k1 As String = selectedRow("kesulitan1").ToString()
        Dim k2 As String = selectedRow("kesulitan2").ToString()
        Dim k3 As String = selectedRow("kesulitan3").ToString()

        If k1 <> "" Then cmbKesulitan.Items.Add(k1)
        If k2 <> "" Then cmbKesulitan.Items.Add(k2)
        If k3 <> "" Then cmbKesulitan.Items.Add(k3)
        UpdateLabelHarga()
    End Sub

    Private Sub UpdateLabelHarga()
        If cmbLayanan.SelectedIndex = -1 OrElse cmbKesulitan.SelectedIndex = -1 Then
            lblHarga.Visible = False
            Exit Sub
        End If
        Dim total As Integer = HitungTotal()
        lblHarga.Text = "Total Harga: Rp " & total.ToString("N0")
        lblHarga.Visible = True
    End Sub

    Private Sub cmbKesulitan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKesulitan.SelectedIndexChanged
        UpdateLabelHarga()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidasiInputJoki(ErrorProvider1, txtUID, txtUsername, txtPassword, txtDetail, cmbLayanan) Then Exit Sub

        If cmbKesulitan.SelectedIndex = -1 Then
            MessageBox.Show("Pilih tingkat kesulitan!")
            Exit Sub
        End If

        Dim total As Integer = HitungTotal()
        Dim sulit As Integer = cmbKesulitan.SelectedIndex + 1
        If SimpanJoki(txtUID.Text, txtUsername.Text, txtPassword.Text, txtDetail.Text, cmbLayanan.SelectedValue.ToString(), sulit, total) Then
            MessageBox.Show("Berhasil simpan!")
            TampilData()
            Kosongkan()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If txtUID.Text = "" Then
            MessageBox.Show("Pilih data di tabel dulu!")
            Exit Sub
        End If

        If cmbKesulitan.SelectedIndex = -1 Then
            MessageBox.Show("Pilih tingkat kesulitan!")
            Exit Sub
        End If

        Dim total As Integer = HitungTotal()
        Dim sulit As Integer = cmbKesulitan.SelectedIndex + 1
        If UbahJoki(txtUID.Text, txtUsername.Text, txtPassword.Text, txtDetail.Text, cmbLayanan.SelectedValue.ToString(), sulit, total) Then
            MessageBox.Show("Data UID " & txtUID.Text & " berhasil diupdate!")
            TampilData()
            Kosongkan()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtUID.Text = "" Then
            MessageBox.Show("Pilih data di tabel dulu!")
            Exit Sub
        End If

        Dim yakin = MessageBox.Show("Hapus UID " & txtUID.Text & "?", "Konfirmasi", MessageBoxButtons.YesNo)
        If yakin = DialogResult.Yes Then
            If HapusJoki(txtUID.Text) Then
                MessageBox.Show("Data terhapus!")
                TampilData()
                Kosongkan()
            End If
        End If
    End Sub

    Private Sub dgvJoki_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJoki.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvJoki.Rows(e.RowIndex)
            txtUID.Text = row.Cells("uid").Value.ToString()
            txtUsername.Text = row.Cells("username").Value.ToString()
            txtPassword.Text = row.Cells("password").Value.ToString()
            txtUID.Enabled = False
            txtDetail.Text = row.Cells("detail").Value.ToString()
            cmbLayanan.Text = row.Cells("Jenis Layanan").Value.ToString()

            ' Set kesulitan berdasarkan index (nilai DB 1/2/3 → index 0/1/2)
            Dim kesulitanVal As String = row.Cells("kesulitan").Value.ToString()
            Dim idx As Integer = 0
            If Integer.TryParse(kesulitanVal, idx) AndAlso idx >= 1 AndAlso idx <= 3 Then
                If cmbKesulitan.Items.Count >= idx Then
                    cmbKesulitan.SelectedIndex = idx - 1
                End If
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosongkan()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" Then
            TampilData()
        Else
            dgvJoki.DataSource = CariJoki(txtSearch.Text.Trim())
        End If
    End Sub

    Private Sub btnMasterLayanan_Click(sender As Object, e As EventArgs) Handles btnMasterLayanan.Click
        Form2.ShowDialog()
        TampilData()
        IsiComboLayanan()
    End Sub

    Private Sub txtUID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUID.KeyPress
        ValidationModule.HanyaAngka(e)
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        If txtUID.Text = "" Then Exit Sub
        If UpdateStatusJoki(txtUID.Text, "3") Then
            MessageBox.Show("Status diupdate ke Selesai!")
            TampilData()
        End If
    End Sub

    Private Sub btnLihatPendapatan_Click(sender As Object, e As EventArgs) Handles btnLihatPendapatan.Click
        Dim total As Integer = HitungTotalPendapatan()
        MessageBox.Show("Total Pendapatan dari Order Selesai: Rp " & total.ToString("N0"), "Laporan Keuangan")
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormLogin.Show()
    End Sub

End Class