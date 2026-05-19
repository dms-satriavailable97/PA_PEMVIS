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
        CType(picQR, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Monotype Corsiva", 36F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
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
        lblTotal.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        lblTotal.ForeColor = Color.Coral
        lblTotal.Location = New Point(810, 166)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(500, 40)
        lblTotal.TabIndex = 48
        lblTotal.Text = "Total Tagihan :"
        ' 
        ' lblMetode
        ' 
        lblMetode.BackColor = Color.Transparent
        lblMetode.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        lblMetode.ForeColor = Color.Coral
        lblMetode.Location = New Point(810, 326)
        lblMetode.Name = "lblMetode"
        lblMetode.Size = New Size(500, 40)
        lblMetode.TabIndex = 49
        lblMetode.Text = "Metode Pembayaran :"
        ' 
        ' lblInstruksi
        ' 
        lblInstruksi.BackColor = Color.Transparent
        lblInstruksi.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        lblInstruksi.ForeColor = Color.Coral
        lblInstruksi.Location = New Point(810, 366)
        lblInstruksi.Name = "lblInstruksi"
        lblInstruksi.Size = New Size(500, 40)
        lblInstruksi.TabIndex = 50
        lblInstruksi.Text = "Instruksi"
        lblInstruksi.TextAlign = ContentAlignment.TopCenter
        ' 
        ' txtInfoBayar
        ' 
        txtInfoBayar.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtInfoBayar.Location = New Point(870, 410)
        txtInfoBayar.Margin = New Padding(3, 4, 3, 4)
        txtInfoBayar.Name = "txtInfoBayar"
        txtInfoBayar.ReadOnly = True
        txtInfoBayar.Size = New Size(386, 25)
        txtInfoBayar.TabIndex = 51
        txtInfoBayar.TextAlign = HorizontalAlignment.Center
        ' 
        ' picQR
        ' 
        picQR.Image = My.Resources.Resources.QRPembayaran
        picQR.Location = New Point(966, 453)
        picQR.Name = "picQR"
        picQR.Size = New Size(182, 182)
        picQR.SizeMode = PictureBoxSizeMode.Zoom
        picQR.TabIndex = 52
        picQR.TabStop = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.IndianRed
        btnBatal.Font = New Font("Microsoft Sans Serif", 9F)
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
        btnKonfirmasi.Font = New Font("Microsoft Sans Serif", 9F)
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
        lblUID.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        lblUID.ForeColor = Color.Coral
        lblUID.Location = New Point(810, 206)
        lblUID.Name = "lblUID"
        lblUID.Size = New Size(500, 40)
        lblUID.TabIndex = 55
        lblUID.Text = "UID :"
        ' 
        ' lblDetail
        ' 
        lblDetail.BackColor = Color.Transparent
        lblDetail.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        lblDetail.ForeColor = Color.Coral
        lblDetail.Location = New Point(810, 246)
        lblDetail.Name = "lblDetail"
        lblDetail.Size = New Size(500, 40)
        lblDetail.TabIndex = 56
        lblDetail.Text = "Target/Detail :"
        ' 
        ' lblLayananKesulitan
        ' 
        lblLayananKesulitan.BackColor = Color.Transparent
        lblLayananKesulitan.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        lblLayananKesulitan.ForeColor = Color.Coral
        lblLayananKesulitan.Location = New Point(810, 286)
        lblLayananKesulitan.Name = "lblLayananKesulitan"
        lblLayananKesulitan.Size = New Size(500, 40)
        lblLayananKesulitan.TabIndex = 57
        lblLayananKesulitan.Text = "Layanan / Kesulitan :"
        ' 
        ' FormPembayaran
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackgroundImage = My.Resources.Resources.ColumbinaMy
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1445, 819)
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
End Class