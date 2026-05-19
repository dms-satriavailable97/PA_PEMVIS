Imports MySqlConnector

Public Class Form3

    Private dtLayanan As DataTable
    Private dtMetode As DataTable

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsiComboLayanan()
        IsiComboMetode()
        TampilDataUser()
        Kosongkan()
    End Sub


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
            If dgvJokiUser.Columns.Contains("kesulitan") Then dgvJokiUser.Columns("kesulitan").Visible = False
            dgvJokiUser.Columns("Jenis Layanan").HeaderText = "Jenis Layanan"
            dgvJokiUser.Columns("Status").HeaderText = "Status Progres"
            dgvJokiUser.Columns("total_harga").HeaderText = "Tagihan"

            If dgvJokiUser.Columns.Contains("metode_pembayaran") Then
                dgvJokiUser.Columns("metode_pembayaran").HeaderText = "Metode Bayar"
                dgvJokiUser.Columns("metode_pembayaran").Visible = True
            End If

            If dgvJokiUser.Columns.Contains("tgl_transaksi") Then
                dgvJokiUser.Columns("tgl_transaksi").HeaderText = "Tanggal Transaksi"
                dgvJokiUser.Columns("tgl_transaksi").Visible = True
            End If

            If dgvJokiUser.Columns.Contains("id_transaksi") Then dgvJokiUser.Columns("id_transaksi").Visible = False
            If dgvJokiUser.Columns.Contains("harga_dasar") Then dgvJokiUser.Columns("harga_dasar").Visible = False
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
        cmbMetodeBayar.SelectedIndex = -1
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

        If CekPesananAktifUser(DataModule.SessionUsername) Then
            MessageBox.Show("Akun Anda masih memiliki pesanan yang belum selesai (Pending)." & vbCrLf & "Mohon tunggu sampai pesanan sebelumnya diselesaikan oleh Admin sebelum membuat pesanan baru.", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If cmbMetodeBayar.SelectedIndex = -1 Then
            MessageBox.Show("Pilih metode pembayaran terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim konfirmasi = MessageBox.Show("Apakah Anda yakin data pesanan sudah benar dan ingin mengirimkannya?", "Konfirmasi Pesanan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.Yes Then
            Dim uid As String = txtUID.Text.Trim()
            Dim total As Integer = HitungTotal()
            Dim sulit As Integer = cmbKesulitan.SelectedIndex + 1
            Dim idLay As String = cmbLayanan.SelectedValue.ToString()

            Dim idMetodeDipilih As String = cmbMetodeBayar.SelectedValue.ToString()
            Dim idTransaksiOtomatis As String = GenerateIDTransaksi()

            If BuatPesananUser(uid, txtUsername.Text, txtPassword.Text, txtDetail.Text, idLay, sulit, total, DataModule.SessionUsername, idTransaksiOtomatis, idMetodeDipilih) Then
                MessageBox.Show("Pesanan berhasil dikirim!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Kosongkan()
                TampilDataUser()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Dim konfirmasi = MessageBox.Show("Apakah Anda yakin ingin membatalkan dan mengosongkan seluruh isian form ini?", "Konfirmasi Batal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If konfirmasi = DialogResult.Yes Then
            Kosongkan()
        End If
    End Sub

    Private Sub txtUID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUID.KeyPress
        ValidationModule.HanyaAngka(e)
    End Sub

    Private Sub Form3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormLogin.Show()
    End Sub

    Private Sub btnCetakStruk_Click(sender As Object, e As EventArgs) Handles btnCetakStruk.Click
        If dgvJokiUser.SelectedRows.Count = 0 Then
            MessageBox.Show("Silakan klik/pilih salah satu pesanan di tabel terlebih dahulu!", "Pilih Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim row As DataGridViewRow = dgvJokiUser.SelectedRows(0)

        Dim dataCetak As New StrukModule.DataStruk() With {
            .IdTransaksi = If(IsDBNull(row.Cells("id_transaksi").Value), "TRX-Menunggu", row.Cells("id_transaksi").Value.ToString()),
            .Tanggal = If(IsDBNull(row.Cells("tgl_order").Value), DateTime.Now, Convert.ToDateTime(row.Cells("tgl_order").Value)),
            .Kasir = "Sistem Otomatis",
            .Pelanggan = DataModule.SessionUsername,
            .MetodePembayaran = If(IsDBNull(row.Cells("Metode Bayar").Value), "Menunggu", row.Cells("Metode Bayar").Value.ToString()),
            .NamaLayanan = row.Cells("Jenis Layanan").Value.ToString(),
            .HargaDasar = Convert.ToInt32(row.Cells("harga_dasar").Value),
            .TingkatKesulitan = Convert.ToInt32(row.Cells("kesulitan").Value),
            .TotalHarga = Convert.ToInt32(row.Cells("total_harga").Value),
            .JumlahBayar = Convert.ToInt32(row.Cells("total_harga").Value),
            .Kembali = 0
        }

        StrukModule.CetakStrukPembelian(dataCetak)
    End Sub

    Sub IsiComboMetode()
        dtMetode = DataModule.GetMetodeForCombo()
        cmbMetodeBayar.DataSource = dtMetode
        cmbMetodeBayar.DisplayMember = "nama_metode"
        cmbMetodeBayar.ValueMember = "id_metode"
        cmbMetodeBayar.SelectedIndex = -1
    End Sub

End Class