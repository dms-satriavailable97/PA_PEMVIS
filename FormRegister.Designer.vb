<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegister
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlMain = New Panel()
        pnlForm = New Panel()
        chkShowPassword = New CheckBox()
        btnBatal = New Button()
        btnDaftar = New Button()
        txtKonfirmasi = New TextBox()
        lblKonfirmasi = New Label()
        txtPassword = New TextBox()
        lblPassword = New Label()
        txtUsername = New TextBox()
        lblUsername = New Label()
        lblFormTitle = New Label()
        pnlHeader = New Panel()
        lblSubTitle = New Label()
        lblTitle = New Label()
        pnlMain.SuspendLayout()
        pnlForm.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(250))
        pnlMain.Controls.Add(pnlForm)
        pnlMain.Controls.Add(pnlHeader)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(0, 0)
        pnlMain.Margin = New Padding(4, 5, 4, 5)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(600, 933)
        pnlMain.TabIndex = 0
        ' 
        ' pnlForm
        ' 
        pnlForm.BackColor = Color.White
        pnlForm.BorderStyle = BorderStyle.FixedSingle
        pnlForm.Controls.Add(chkShowPassword)
        pnlForm.Controls.Add(btnBatal)
        pnlForm.Controls.Add(btnDaftar)
        pnlForm.Controls.Add(txtKonfirmasi)
        pnlForm.Controls.Add(lblKonfirmasi)
        pnlForm.Controls.Add(txtPassword)
        pnlForm.Controls.Add(lblPassword)
        pnlForm.Controls.Add(txtUsername)
        pnlForm.Controls.Add(lblUsername)
        pnlForm.Controls.Add(lblFormTitle)
        pnlForm.Location = New Point(43, 225)
        pnlForm.Margin = New Padding(4, 5, 4, 5)
        pnlForm.Name = "pnlForm"
        pnlForm.Size = New Size(513, 665)
        pnlForm.TabIndex = 0
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.Font = New Font("Segoe UI", 8.5F)
        chkShowPassword.ForeColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        chkShowPassword.Location = New Point(29, 397)
        chkShowPassword.Margin = New Padding(4, 5, 4, 5)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(187, 27)
        chkShowPassword.TabIndex = 0
        chkShowPassword.Text = "Tampilkan Password"
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.FromArgb(CByte(149), CByte(165), CByte(166))
        btnBatal.Cursor = Cursors.Hand
        btnBatal.FlatAppearance.BorderSize = 0
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(29, 530)
        btnBatal.Margin = New Padding(4, 5, 4, 5)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(457, 63)
        btnBatal.TabIndex = 1
        btnBatal.Text = "Kembali ke Login"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' btnDaftar
        ' 
        btnDaftar.BackColor = Color.FromArgb(CByte(39), CByte(174), CByte(96))
        btnDaftar.Cursor = Cursors.Hand
        btnDaftar.FlatAppearance.BorderSize = 0
        btnDaftar.FlatStyle = FlatStyle.Flat
        btnDaftar.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnDaftar.ForeColor = Color.White
        btnDaftar.Location = New Point(29, 450)
        btnDaftar.Margin = New Padding(4, 5, 4, 5)
        btnDaftar.Name = "btnDaftar"
        btnDaftar.Size = New Size(457, 63)
        btnDaftar.TabIndex = 2
        btnDaftar.Text = "Daftar"
        btnDaftar.UseVisualStyleBackColor = False
        ' 
        ' txtKonfirmasi
        ' 
        txtKonfirmasi.BorderStyle = BorderStyle.FixedSingle
        txtKonfirmasi.Font = New Font("Segoe UI", 10.0F)
        txtKonfirmasi.Location = New Point(29, 337)
        txtKonfirmasi.Margin = New Padding(4, 5, 4, 5)
        txtKonfirmasi.Name = "txtKonfirmasi"
        txtKonfirmasi.PasswordChar = "*"c
        txtKonfirmasi.Size = New Size(456, 34)
        txtKonfirmasi.TabIndex = 3
        ' 
        ' lblKonfirmasi
        ' 
        lblKonfirmasi.Font = New Font("Segoe UI", 9.0F)
        lblKonfirmasi.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        lblKonfirmasi.Location = New Point(29, 300)
        lblKonfirmasi.Margin = New Padding(4, 0, 4, 0)
        lblKonfirmasi.Name = "lblKonfirmasi"
        lblKonfirmasi.Size = New Size(457, 33)
        lblKonfirmasi.TabIndex = 4
        lblKonfirmasi.Text = "Konfirmasi Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 10.0F)
        txtPassword.Location = New Point(29, 237)
        txtPassword.Margin = New Padding(4, 5, 4, 5)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(456, 34)
        txtPassword.TabIndex = 5
        ' 
        ' lblPassword
        ' 
        lblPassword.Font = New Font("Segoe UI", 9.0F)
        lblPassword.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        lblPassword.Location = New Point(29, 200)
        lblPassword.Margin = New Padding(4, 0, 4, 0)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(457, 33)
        lblPassword.TabIndex = 6
        lblPassword.Text = "Password"
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 10.0F)
        txtUsername.Location = New Point(29, 137)
        txtUsername.Margin = New Padding(4, 5, 4, 5)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(456, 34)
        txtUsername.TabIndex = 7
        ' 
        ' lblUsername
        ' 
        lblUsername.Font = New Font("Segoe UI", 9.0F)
        lblUsername.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        lblUsername.Location = New Point(29, 100)
        lblUsername.Margin = New Padding(4, 0, 4, 0)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(457, 33)
        lblUsername.TabIndex = 8
        lblUsername.Text = "Username"
        ' 
        ' lblFormTitle
        ' 
        lblFormTitle.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblFormTitle.ForeColor = Color.FromArgb(CByte(39), CByte(174), CByte(96))
        lblFormTitle.Location = New Point(29, 30)
        lblFormTitle.Margin = New Padding(4, 0, 4, 0)
        lblFormTitle.Name = "lblFormTitle"
        lblFormTitle.Size = New Size(457, 50)
        lblFormTitle.TabIndex = 9
        lblFormTitle.Text = "Daftar Akun Baru"
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(39), CByte(174), CByte(96))
        pnlHeader.Controls.Add(lblSubTitle)
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(4, 5, 4, 5)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(600, 200)
        pnlHeader.TabIndex = 1
        ' 
        ' lblSubTitle
        ' 
        lblSubTitle.Font = New Font("Segoe UI", 10.0F)
        lblSubTitle.ForeColor = Color.FromArgb(CByte(200), CByte(240), CByte(215))
        lblSubTitle.Location = New Point(0, 120)
        lblSubTitle.Margin = New Padding(4, 0, 4, 0)
        lblSubTitle.Name = "lblSubTitle"
        lblSubTitle.Size = New Size(600, 50)
        lblSubTitle.TabIndex = 0
        lblSubTitle.Text = "Buat akun baru"
        lblSubTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTitle
        ' 
        lblTitle.Font = New Font("Segoe UI", 22.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(0, 42)
        lblTitle.Margin = New Padding(4, 0, 4, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(600, 75)
        lblTitle.TabIndex = 1
        lblTitle.Text = "Joki Genshin Impact"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FormRegister
        ' 
        AutoScaleDimensions = New SizeF(144.0F, 144.0F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(250))
        ClientSize = New Size(600, 933)
        Controls.Add(pnlMain)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        Name = "FormRegister"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Daftar Akun - Joki Genshin"
        pnlMain.ResumeLayout(False)
        pnlForm.ResumeLayout(False)
        pnlForm.PerformLayout()
        pnlHeader.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle As System.Windows.Forms.Label
    Friend WithEvents pnlForm As System.Windows.Forms.Panel
    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblKonfirmasi As System.Windows.Forms.Label
    Friend WithEvents txtKonfirmasi As System.Windows.Forms.TextBox
    Friend WithEvents chkShowPassword As System.Windows.Forms.CheckBox
    Friend WithEvents btnDaftar As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button

End Class
