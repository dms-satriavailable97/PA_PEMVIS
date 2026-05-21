<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPembayaran
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label4 = New Label()
        lblTotal = New Label()
        lblMetode = New Label()
        lblInstruksi = New Label()
        txtInfoBayar = New TextBox()
        picQR = New PictureBox()
        btnBatal = New Button()
        btnKonfirmasi = New Button()
        lblUID = New Label()
        lblDetail = New Label()
        lblLayananKesulitan = New Label()
        lblKirimBukti = New Label()
        lblAtasNama2 = New Label()
        lblKirimBukti2 = New Label()
        CType(picQR, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Monotype Corsiva", 36.0F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.IndianRed
        Label4.Location = New Point(810, 55)
        Label4.Name = "Label4"
        Label4.Size = New Size(521, 111)
        Label4.TabIndex = 47
        Label4.Text = "Form Pembayaran"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTotal
        ' 
        lblTotal.BackColor = Color.Transparent
        lblTotal.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Bold)
        lblTotal.ForeColor = Color.Coral
        lblTotal.Location = New Point(810, 150)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(500, 30)
        lblTotal.TabIndex = 48
        lblTotal.Text = "Total Tagihan :"
        ' 
        ' lblMetode
        ' 
        lblMetode.BackColor = Color.Transparent
        lblMetode.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Bold)
        lblMetode.ForeColor = Color.Coral
        lblMetode.Location = New Point(810, 261)
        lblMetode.Name = "lblMetode"
        lblMetode.Size = New Size(500, 40)
        lblMetode.TabIndex = 49
        lblMetode.Text = "Metode Pembayaran :"
        ' 
        ' lblInstruksi
        ' 
        lblInstruksi.BackColor = Color.Transparent
        lblInstruksi.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Bold)
        lblInstruksi.ForeColor = Color.Coral
        lblInstruksi.Location = New Point(801, 301)
        lblInstruksi.Name = "lblInstruksi"
        lblInstruksi.Size = New Size(500, 40)
        lblInstruksi.TabIndex = 50
        lblInstruksi.Text = "Instruksi"
        lblInstruksi.TextAlign = ContentAlignment.TopCenter
        ' 
        ' txtInfoBayar
        ' 
        txtInfoBayar.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtInfoBayar.Location = New Point(870, 328)
        txtInfoBayar.Margin = New Padding(3, 4, 3, 4)
        txtInfoBayar.Name = "txtInfoBayar"
        txtInfoBayar.ReadOnly = True
        txtInfoBayar.Size = New Size(386, 29)
        txtInfoBayar.TabIndex = 51
        txtInfoBayar.TextAlign = HorizontalAlignment.Center
        ' 
        ' picQR
        ' 
        picQR.Image = My.Resources.Resources.QRPembayaran
        picQR.Location = New Point(967, 328)
        picQR.Name = "picQR"
        picQR.Size = New Size(182, 182)
        picQR.SizeMode = PictureBoxSizeMode.Zoom
        picQR.TabIndex = 52
        picQR.TabStop = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.IndianRed
        btnBatal.Font = New Font("Microsoft Sans Serif", 9.0F)
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(824, 666)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(155, 46)
        btnBatal.TabIndex = 53
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' btnKonfirmasi
        ' 
        btnKonfirmasi.BackColor = Color.IndianRed
        btnKonfirmasi.Font = New Font("Microsoft Sans Serif", 9.0F)
        btnKonfirmasi.ForeColor = Color.White
        btnKonfirmasi.Location = New Point(1137, 666)
        btnKonfirmasi.Name = "btnKonfirmasi"
        btnKonfirmasi.Size = New Size(155, 46)
        btnKonfirmasi.TabIndex = 54
        btnKonfirmasi.Text = "Konfirmasi"
        btnKonfirmasi.UseVisualStyleBackColor = False
        ' 
        ' lblUID
        ' 
        lblUID.BackColor = Color.Transparent
        lblUID.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Bold)
        lblUID.ForeColor = Color.Coral
        lblUID.Location = New Point(810, 180)
        lblUID.Name = "lblUID"
        lblUID.Size = New Size(500, 30)
        lblUID.TabIndex = 55
        lblUID.Text = "UID :"
        ' 
        ' lblDetail
        ' 
        lblDetail.BackColor = Color.Transparent
        lblDetail.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Bold)
        lblDetail.ForeColor = Color.Coral
        lblDetail.Location = New Point(810, 206)
        lblDetail.Name = "lblDetail"
        lblDetail.Size = New Size(500, 28)
        lblDetail.TabIndex = 56
        lblDetail.Text = "Target/Detail :"
        ' 
        ' lblLayananKesulitan
        ' 
        lblLayananKesulitan.BackColor = Color.Transparent
        lblLayananKesulitan.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Bold)
        lblLayananKesulitan.ForeColor = Color.Coral
        lblLayananKesulitan.Location = New Point(810, 234)
        lblLayananKesulitan.Name = "lblLayananKesulitan"
        lblLayananKesulitan.Size = New Size(500, 27)
        lblLayananKesulitan.TabIndex = 57
        lblLayananKesulitan.Text = "Layanan / Kesulitan : "
        ' 
        ' lblKirimBukti
        ' 
        lblKirimBukti.BackColor = Color.Transparent
        lblKirimBukti.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Bold)
        lblKirimBukti.ForeColor = Color.Coral
        lblKirimBukti.Location = New Point(801, 533)
        lblKirimBukti.Name = "lblKirimBukti"
        lblKirimBukti.Size = New Size(500, 40)
        lblKirimBukti.TabIndex = 59
        lblKirimBukti.Text = "Kirim Bukti Pembayaran Ke No :"
        ' 
        ' lblAtasNama2
        ' 
        lblAtasNama2.BackColor = Color.Transparent
        lblAtasNama2.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Bold)
        lblAtasNama2.ForeColor = Color.Coral
        lblAtasNama2.Location = New Point(810, 371)
        lblAtasNama2.Name = "lblAtasNama2"
        lblAtasNama2.Size = New Size(500, 40)
        lblAtasNama2.TabIndex = 60
        lblAtasNama2.Text = "Atas Nama : "
        ' 
        ' lblKirimBukti2
        ' 
        lblKirimBukti2.BackColor = Color.Transparent
        lblKirimBukti2.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Bold)
        lblKirimBukti2.ForeColor = Color.Coral
        lblKirimBukti2.Location = New Point(810, 401)
        lblKirimBukti2.Name = "lblKirimBukti2"
        lblKirimBukti2.Size = New Size(500, 40)
        lblKirimBukti2.TabIndex = 61
        lblKirimBukti2.Text = "Kirim Bukti Pembayaran Ke No :"
        ' 
        ' FormPembayaran
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackgroundImage = My.Resources.Resources.ColumbinaMy
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1443, 811)
        Controls.Add(lblKirimBukti2)
        Controls.Add(lblAtasNama2)
        Controls.Add(lblKirimBukti)
        Controls.Add(lblLayananKesulitan)
        Controls.Add(lblDetail)
        Controls.Add(lblUID)
        Controls.Add(btnKonfirmasi)
        Controls.Add(btnBatal)
        Controls.Add(picQR)
        Controls.Add(txtInfoBayar)
        Controls.Add(lblInstruksi)
        Controls.Add(lblMetode)
        Controls.Add(lblTotal)
        Controls.Add(Label4)
        MaximumSize = New Size(1461, 858)
        MinimumSize = New Size(1461, 858)
        Name = "FormPembayaran"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormPembayaran"
        CType(picQR, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblMetode As Label
    Friend WithEvents lblInstruksi As Label
    Friend WithEvents txtInfoBayar As TextBox
    Friend WithEvents picQR As PictureBox
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnKonfirmasi As Button
    Friend WithEvents lblUID As Label
    Friend WithEvents lblDetail As Label
    Friend WithEvents lblLayananKesulitan As Label
    Friend WithEvents lblKirimBukti As Label
    Friend WithEvents lblAtasNama2 As Label
    Friend WithEvents lblKirimBukti2 As Label
End Class