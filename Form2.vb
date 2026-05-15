Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tampil()
        Kosongkan()
    End Sub

    Sub Tampil()
        dgvMasterLayanan.DataSource = TampilLayanan()
    End Sub

    Sub Kosongkan()
        txtIDLayanan.Clear()
        txtNamaLayanan.Clear()
        txtHargaDasar.Clear()

        txtIDLayanan.Enabled = True
        txtIDLayanan.Focus()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtIDLayanan.Text = "" Or txtNamaLayanan.Text = "" Or txtHargaDasar.Text = "" Then
            MessageBox.Show("Semua data layanan harus diisi!")
            Exit Sub
        End If

        If SimpanLayanan(txtIDLayanan.Text, txtNamaLayanan.Text, Convert.ToInt32(txtHargaDasar.Text)) Then
            MessageBox.Show("Layanan baru berhasil ditambahkan")
            Tampil()
            Kosongkan()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Dim harga As Integer
        If Not Integer.TryParse(txtHargaDasar.Text, harga) Then
            MessageBox.Show("Harga harus berupa angka!")
            Exit Sub
        End If

        If UbahLayanan(txtIDLayanan.Text, txtNamaLayanan.Text, harga) Then
            MessageBox.Show("Layanan berhasil diperbarui!")
            Tampil()
            Kosongkan()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtIDLayanan.Text = "" Then
            MessageBox.Show("Pilih layanan yang mau dihapus!")
            Exit Sub
        End If

        Dim tanya = MessageBox.Show("Hapus layanan " & txtNamaLayanan.Text & "?", "Konfirmasi", MessageBoxButtons.YesNo)
        If tanya = DialogResult.Yes Then
            If HapusLayanan(txtIDLayanan.Text) Then
                MessageBox.Show("Layanan dihapus!")
                Tampil()
                Kosongkan()
                dgvMasterLayanan.ClearSelection()
            End If
        End If
    End Sub

    Private Sub dgvMasterLayanan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMasterLayanan.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvMasterLayanan.Rows(e.RowIndex)
            txtIDLayanan.Text = row.Cells("id_layanan").Value.ToString()
            txtNamaLayanan.Text = row.Cells("nama_layanan").Value.ToString()
            txtHargaDasar.Text = row.Cells("harga_dasar").Value.ToString()

            txtIDLayanan.Enabled = False ' ID tidak boleh diganti karena itu kunci utama
        End If
    End Sub

    Private Sub LabelTitle_Click(sender As Object, e As EventArgs) Handles LabelTitle.Click

    End Sub
End Class