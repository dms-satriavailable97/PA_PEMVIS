Public Class FormPembayaran
    Private _namaMetode As String
    Private _totalBayar As Integer
    Private _uid As String
    Private _detail As String
    Private _layanan As String
    Private _kesulitan As String

    Public Sub SetupPembayaran(metode As String, total As Integer, uid As String, detail As String, layanan As String, kesulitan As String)
        _namaMetode = metode
        _totalBayar = total
        _uid = uid
        _detail = detail
        _layanan = layanan
        _kesulitan = kesulitan
    End Sub

    Private Sub FormPembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotal.Text = "Total Tagihan : Rp " & _totalBayar.ToString("N0")
        lblMetode.Text = "Metode Pembayaran : " & _namaMetode

        lblUID.Text = "UID : " & _uid
        lblDetail.Text = "Target/Detail : " & _detail
        lblLayananKesulitan.Text = "Layanan / Kesulitan : " & _layanan & ", " & _kesulitan

        Dim metodeLower As String = _namaMetode.ToLower()

        If metodeLower.Contains("bank") OrElse metodeLower.Contains("transfer") Then
            picQR.Visible = False
            lblInstruksi.Text = "Silakan transfer ke Virtual Account (VA) berikut :"
            txtInfoBayar.Text = "8890" & DateTime.Now.ToString("MMddHHmmss")
            txtInfoBayar.Visible = True

        ElseIf metodeLower.Contains("qris") OrElse metodeLower.Contains("gopay") OrElse metodeLower.Contains("shopee") OrElse metodeLower.Contains("dana") Then
            picQR.Visible = True
            lblInstruksi.Text = "Silakan scan QR Code berikut atau hubungi WA Admin :"
            txtInfoBayar.Text = "WA Admin : 0812-3456-7890"
            txtInfoBayar.Visible = True
        Else
            picQR.Visible = False
            lblInstruksi.Text = "Silakan selesaikan pembayaran ke WA Admin."
            txtInfoBayar.Text = "WA Admin : 0812-3456-7890"
            txtInfoBayar.Visible = True
        End If
    End Sub

    Private Sub btnKonfirmasi_Click(sender As Object, e As EventArgs) Handles btnKonfirmasi.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class