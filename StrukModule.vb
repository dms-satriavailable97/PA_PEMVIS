Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms

Module StrukModule

    Public Class DataStruk
        Public Property IdTransaksi As String
        Public Property Tanggal As DateTime
        Public Property Kasir As String
        Public Property Pelanggan As String
        Public Property MetodePembayaran As String
        Public Property NamaLayanan As String
        Public Property HargaDasar As Integer
        Public Property TingkatKesulitan As Integer
        Public Property TotalHarga As Integer
        Public Property JumlahBayar As Integer
        Public Property Kembali As Integer
    End Class

    Private currentData As DataStruk

    Public Sub CetakStrukPembelian(data As DataStruk)
        currentData = data

        Dim pd As New PrintDocument()

        Dim paperSize As New PaperSize("Thermal", 300, 600)
        pd.DefaultPageSettings.PaperSize = paperSize

        AddHandler pd.PrintPage, AddressOf FormatStruk_PrintPage

        Dim ppd As New PrintPreviewDialog()
        ppd.Document = pd
        ppd.ShowDialog()
    End Sub

    Private Sub FormatStruk_PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim g As Graphics = e.Graphics

        Dim fontJudul As New Font("Arial", 14, FontStyle.Bold)
        Dim fontSubJudul As New Font("Arial", 9, FontStyle.Regular)
        Dim fontIsi As New Font("Arial", 9, FontStyle.Regular)
        Dim fontIsiBold As New Font("Arial", 9, FontStyle.Bold)

        Dim brush As SolidBrush = New SolidBrush(Color.Black)

        Dim formatCenter As New StringFormat() With {.Alignment = StringAlignment.Center}
        Dim formatRight As New StringFormat() With {.Alignment = StringAlignment.Far}

        Dim startX As Integer = 10
        Dim startY As Integer = 10
        Dim lebarKertas As Integer = e.PageBounds.Width - 20
        Dim yPos As Integer = startY
        Dim offset As Integer = 20

        g.DrawString("JOKI GENSHIN IMPACT", fontJudul, brush, lebarKertas \ 2, yPos, formatCenter)
        yPos += 25
        g.DrawString("Jl. Court of Fontaine No. 99, Fontaine", fontSubJudul, brush, lebarKertas \ 2, yPos, formatCenter)
        yPos += 15
        g.DrawString("No. Telp 081234567890", fontSubJudul, brush, lebarKertas \ 2, yPos, formatCenter)
        yPos += 20

        Dim garis As String = "--------------------------------------------------------"
        g.DrawString(garis, fontIsi, brush, startX, yPos)
        yPos += 15

        g.DrawString(currentData.Tanggal.ToString("yyyy-MM-dd"), fontIsi, brush, startX, yPos)
        g.DrawString(currentData.Kasir, fontIsi, brush, lebarKertas, yPos, formatRight)
        yPos += 15

        g.DrawString(currentData.Tanggal.ToString("HH:mm:ss"), fontIsi, brush, startX, yPos)
        g.DrawString(currentData.Pelanggan, fontIsi, brush, lebarKertas, yPos, formatRight)
        yPos += 15

        g.DrawString("Metode: " & currentData.MetodePembayaran, fontIsi, brush, startX, yPos)
        yPos += 25

        g.DrawString("ID Trx: " & currentData.IdTransaksi, fontIsi, brush, startX, yPos)
        yPos += 15

        g.DrawString(garis, fontIsi, brush, startX, yPos)
        yPos += 15

        g.DrawString("1. " & currentData.NamaLayanan, fontIsiBold, brush, startX, yPos)
        yPos += 15

        Dim detailItem As String = "1 x " & currentData.HargaDasar.ToString("N0") & " (Index Kesulitan: " & currentData.TingkatKesulitan & ")"
        g.DrawString(detailItem, fontIsi, brush, startX + 15, yPos)

        g.DrawString("Rp " & currentData.TotalHarga.ToString("N0"), fontIsi, brush, lebarKertas, yPos, formatRight)
        yPos += 20

        g.DrawString(garis, fontIsi, brush, startX, yPos)
        yPos += 15

        g.DrawString("Total QTY : 1", fontIsi, brush, startX, yPos)
        yPos += 20

        g.DrawString("Sub Total", fontIsi, brush, startX, yPos)
        g.DrawString("Rp " & currentData.TotalHarga.ToString("N0"), fontIsi, brush, lebarKertas, yPos, formatRight)
        yPos += 15

        g.DrawString("Total", fontIsiBold, brush, startX, yPos)
        g.DrawString("Rp " & currentData.TotalHarga.ToString("N0"), fontIsiBold, brush, lebarKertas, yPos, formatRight)
        yPos += 15

        g.DrawString("Bayar (" & currentData.MetodePembayaran & ")", fontIsi, brush, startX, yPos)
        g.DrawString("Rp " & currentData.JumlahBayar.ToString("N0"), fontIsi, brush, lebarKertas, yPos, formatRight)
        yPos += 15

        g.DrawString("Kembali", fontIsi, brush, startX, yPos)
        g.DrawString("Rp " & currentData.Kembali.ToString("N0"), fontIsi, brush, lebarKertas, yPos, formatRight)
        yPos += 25

        g.DrawString("Terimakasih Telah Menggunakan Jasa Kami", fontIsi, brush, lebarKertas \ 2, yPos, formatCenter)
        yPos += 15
        g.DrawString("Simpan struk ini sebagai bukti pesanan", fontIsi, brush, lebarKertas \ 2, yPos, formatCenter)
    End Sub

End Module