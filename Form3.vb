Imports MySqlConnector

Public Class Form3

    Private dtLayanan As DataTable

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsiComboLayanan()
        TampilDataUser()
        Kosongkan()
    End Sub

    ' --- MEMUAT RIWAYAT ORDER KHUSUS USER INI ---
    Sub TampilDataUser()
        dgvJokiUser.DataSource = TampilJokiUser(DataModule.SessionUsername)
        AturDGVUser()
    End Sub

    Sub AturDGVUser()
        If dgvJokiUser.Columns.Count > 0 Then
            dgvJokiUser.Columns("uid").HeaderText = "UID Game"
            dgvJokiUser.Columns("username").HeaderText = "Akun Game"
            dgvJokiUser.Columns("password").HeaderText = "Password"
            dgvJokiUser.Columns("detail").HeaderText = "Detail Target"
            dgvJokiUser.Columns("kesulitan").HeaderText = "Index Sulit"
            dgvJokiUser.Columns("Jenis Layanan").HeaderText = "Jenis Layanan"
            dgvJokiUser.Columns("Status").HeaderText = "Status Progres"
            dgvJokiUser.Columns("total_harga").HeaderText = "Tagihan"

            dgvJokiUser.ReadOnly = True
            dgvJokiUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvJokiUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If
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
        lblHarga.Visible = False
        ErrorProvider1.Clear()
        txtUID.Focus()
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

    Private Sub btnPesan_Click(sender As Object, e As EventArgs) Handles btnPesan.Click
        If Not ValidasiInputJoki(ErrorProvider1, txtUID, txtUsername, txtPassword, txtDetail, cmbLayanan) Then Exit Sub

        If cmbKesulitan.SelectedIndex = -1 Then
            MessageBox.Show("Pilih tingkat kesulitan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' --- 1. LOGIKA PEMBLOKIRAN (Berdasarkan Akun Aplikasi) ---
        If CekPesananAktifUser(DataModule.SessionUsername) Then
            MessageBox.Show("Akun Anda masih memiliki pesanan yang belum selesai (Pending)." & vbCrLf & "Mohon tunggu sampai pesanan sebelumnya diselesaikan oleh Admin sebelum membuat pesanan baru.", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        ' --- 2. KIRIM PESANAN BARU ---
        Dim uid As String = txtUID.Text.Trim()
        Dim total As Integer = HitungTotal()
        Dim sulit As Integer = cmbKesulitan.SelectedIndex + 1
        Dim idLay As String = cmbLayanan.SelectedValue.ToString()

        If BuatPesananUser(uid, txtUsername.Text, txtPassword.Text, txtDetail.Text, idLay, sulit, total, DataModule.SessionUsername) Then
            MessageBox.Show("Pesanan berhasil dikirim ke Admin! Silakan tunggu konfirmasi selanjutnya.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Kosongkan()
            TampilDataUser()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosongkan()
    End Sub

    Private Sub txtUID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUID.KeyPress
        ValidationModule.HanyaAngka(e)
    End Sub

    Private Sub Form3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormLogin.Show()
    End Sub
End Class