Module ValidationModule

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function
    Public Function ValidasiInputJoki(ep As ErrorProvider, txtUID As TextBox, txtUser As TextBox, txtPass As TextBox, txtDetail As TextBox, cmbLay As ComboBox) As Boolean
        Dim v1 = ValidasiTextBox(ep, txtUID, "UID tidak boleh kosong")
        Dim v2 = ValidasiTextBox(ep, txtUser, "Username tidak boleh kosong")
        Dim v3 = ValidasiTextBox(ep, txtPass, "Password tidak boleh kosong")
        Dim v4 = ValidasiTextBox(ep, txtDetail, "Detail pesanan tidak boleh kosong")

        Dim v5 As Boolean = True
        If cmbLay.SelectedIndex = -1 Then
            ep.SetError(cmbLay, "Pilih layanan terlebih dahulu")
            v5 = False
        Else
            ep.SetError(cmbLay, "")
        End If

        Return v1 And v2 And v3 And v4 And v5
    End Function

End Module