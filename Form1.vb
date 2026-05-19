Imports MySqlConnector

Public Class Form1

    Private dtLayanan As DataTable
    Private IsFromDatabase As Boolean = False
    Private CurrentStatusText As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        IsiComboLayanan()
        Kosongkan()
    End Sub

    Sub TampilData()
        dgvJoki.DataSource = TampilJoki()
        AturDGV()
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
        IsFromDatabase = False
        CurrentStatusText = ""
    End Sub

    Sub AturDGV()
        If dgvJoki.Columns.Count > 0 Then
            dgvJoki.Columns("uid").HeaderText = "UID Game"
            dgvJoki.Columns("username").HeaderText = "Akun Game"
            dgvJoki.Columns("password").HeaderText = "Password"
            dgvJoki.Columns("detail").HeaderText = "Detail Target"
            If dgvJoki.Columns.Contains("kesulitan") Then dgvJoki.Columns("kesulitan").Visible = False
            dgvJoki.Columns("total_harga").HeaderText = "Total Tagihan"
            dgvJoki.Columns("tgl_order").HeaderText = "Waktu Pemesanan"
        End If
    End Sub

    Private Function HitungTotal() As Integer
        If cmbLayanan.SelectedIndex = -1 Then Return 0
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


    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If Not IsFromDatabase Then
            MessageBox.Show("Aksi ditolak! Pilih data dari tabel terlebih dahulu sebelum mengubah.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtUID.Text = "" Then
            MessageBox.Show("Pilih data di tabel dulu!")
            Exit Sub
        End If

        If cmbKesulitan.SelectedIndex = -1 Then
            MessageBox.Show("Pilih tingkat kesulitan!")
            Exit Sub
        End If

        Dim konfirmasi = MessageBox.Show("Apakah Anda yakin ingin menyimpan perubahan pada pesanan dengan UID " & txtUID.Text & "?", "Konfirmasi Ubah", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            Dim total As Integer = HitungTotal()
            Dim sulit As Integer = cmbKesulitan.SelectedIndex + 1
            If UbahJoki(txtUID.Text, txtUsername.Text, txtPassword.Text, txtDetail.Text, cmbLayanan.SelectedValue.ToString(), sulit, total) Then
                MessageBox.Show("Data UID " & txtUID.Text & " berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosongkan()
            End If
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If Not IsFromDatabase Then
            MessageBox.Show("Aksi ditolak! Pilih data dari tabel terlebih dahulu sebelum menghapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtUID.Text = "" Then
            MessageBox.Show("Pilih data di tabel dulu!")
            Exit Sub
        End If


        Dim konfirmasi = MessageBox.Show("PERINGATAN: Apakah Anda yakin ingin menghapus pesanan dengan UID " & txtUID.Text & " secara permanen?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Error)

        If konfirmasi = DialogResult.Yes Then
            If HapusJoki(txtUID.Text) Then
                MessageBox.Show("Data berhasil terhapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

            Dim kesulitanVal As String = row.Cells("kesulitan").Value.ToString()
            Dim idx As Integer = 0
            If Integer.TryParse(kesulitanVal, idx) AndAlso idx >= 1 AndAlso idx <= 3 Then
                If cmbKesulitan.Items.Count >= idx Then
                    cmbKesulitan.SelectedIndex = idx - 1
                End If
            End If

            IsFromDatabase = True
            CurrentStatusText = row.Cells("Status").Value.ToString()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Dim konfirmasi = MessageBox.Show("Apakah Anda yakin ingin membatalkan aksi dan mengosongkan form?", "Konfirmasi Batal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If konfirmasi = DialogResult.Yes Then
            Kosongkan()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" Then
            TampilData()
        Else
            dgvJoki.DataSource = CariJoki(txtSearch.Text.Trim())
            AturDGV()
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
        If Not IsFromDatabase OrElse txtUID.Text = "" Then
            MessageBox.Show("Pilih data aktif dari tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If CurrentStatusText = "Pending" Then
            MessageBox.Show("Aksi Ditolak! Pesanan ini masih berstatus 'Pending'." & vbCrLf & "Anda harus memprosesnya terlebih dahulu dengan menekan tombol 'Update Diproses' sebelum menyelesaikannya.", "Alur Kerja Salah", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub

        ElseIf CurrentStatusText = "Selesai" Then
            MessageBox.Show("Pesanan ini memang sudah berstatus 'Selesai'!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim konfirmasi = MessageBox.Show("Apakah Anda yakin ingin menyelesaikan pesanan dengan UID " & txtUID.Text & "?" & vbCrLf & "Tindakan ini akan mengonstruksikan tagihan keuangan ke pendapatan.", "Konfirmasi Selesai", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            If UpdateStatusJoki(txtUID.Text, "3") Then
                MessageBox.Show("Status berhasil diupdate ke Selesai!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosongkan()
            End If
        End If
    End Sub

    Private Sub btnLihatPendapatan_Click(sender As Object, e As EventArgs) Handles btnLihatPendapatan.Click
        Dim total As Integer = HitungTotalPendapatan()
        MessageBox.Show("Total Pendapatan dari Order Selesai: Rp " & total.ToString("N0"), "Laporan Keuangan")
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormLogin.Show()
    End Sub
    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        If Not IsFromDatabase OrElse txtUID.Text = "" Then
            MessageBox.Show("Pilih data aktif dari tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If CurrentStatusText = "Diproses" Then
            MessageBox.Show("Pesanan ini sudah berstatus 'Diproses'!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf CurrentStatusText = "Selesai" Then
            MessageBox.Show("Pesanan sudah selesai, status tidak dapat diturunkan kembali!", "Aksi Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        Dim konfirmasi = MessageBox.Show("Apakah Anda yakin ingin mengubah status pesanan UID " & txtUID.Text & " menjadi 'Diproses'?", "Konfirmasi Proses", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            If UpdateStatusJoki(txtUID.Text, "2") Then
                MessageBox.Show("Status berhasil diupdate menjadi Diproses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosongkan()
            End If
        End If
    End Sub

End Class