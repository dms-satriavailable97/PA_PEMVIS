Imports MySqlConnector

Public Class FormRegister

    Private Sub FormRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Kosongkan()
    End Sub

    Sub Kosongkan()
        txtUsername.Clear()
        txtPassword.Clear()
        txtKonfirmasi.Clear()
        txtUsername.Focus()
    End Sub

    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim konfirmasi As String = txtKonfirmasi.Text.Trim()

        ' Validasi input
        If username = "" Or password = "" Or konfirmasi = "" Then
            MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If username.Length < 4 Then
            MessageBox.Show("Username minimal 4 karakter!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()
            Exit Sub
        End If

        If password.Length < 6 Then
            MessageBox.Show("Password minimal 6 karakter!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Exit Sub
        End If

        If password <> konfirmasi Then
            MessageBox.Show("Konfirmasi password tidak cocok!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtKonfirmasi.Clear()
            txtKonfirmasi.Focus()
            Exit Sub
        End If

        ' Cek username sudah ada
        If CekUsernameAda(username) Then
            MessageBox.Show("Username '" & username & "' sudah digunakan, pilih username lain!", "Username Tidak Tersedia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()
            Exit Sub
        End If

        ' Simpan user baru dengan role "user"
        If RegisterUser(username, password, "user") Then
            MessageBox.Show("Pendaftaran berhasil! Silakan login dengan akun Anda.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Pendaftaran gagal, coba lagi.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            txtPassword.PasswordChar = Chr(0)
            txtKonfirmasi.PasswordChar = Chr(0)
        Else
            txtPassword.PasswordChar = "*"c
            txtKonfirmasi.PasswordChar = "*"c
        End If
    End Sub

    Private Sub pnlHeader_Paint(sender As Object, e As PaintEventArgs) Handles pnlHeader.Paint

    End Sub
End Class
