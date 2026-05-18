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
        chkShowPassword = New CheckBox()
        btnBatal = New Button()
        btnDaftar = New Button()
        txtKonfirmasi = New TextBox()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        SuspendLayout()
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.BackColor = Color.Transparent
        chkShowPassword.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkShowPassword.ForeColor = Color.White
        chkShowPassword.Location = New Point(889, 538)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(185, 25)
        chkShowPassword.TabIndex = 0
        chkShowPassword.Text = "Tampilkan Password"
        chkShowPassword.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.FromArgb(CByte(149), CByte(165), CByte(166))
        btnBatal.Cursor = Cursors.Hand
        btnBatal.FlatAppearance.BorderSize = 0
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(888, 646)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(395, 42)
        btnBatal.TabIndex = 1
        btnBatal.Text = "Kembali ke Login"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' btnDaftar
        ' 
        btnDaftar.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        btnDaftar.Cursor = Cursors.Hand
        btnDaftar.FlatAppearance.BorderSize = 0
        btnDaftar.FlatStyle = FlatStyle.Flat
        btnDaftar.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDaftar.ForeColor = Color.White
        btnDaftar.Location = New Point(888, 589)
        btnDaftar.Name = "btnDaftar"
        btnDaftar.Size = New Size(395, 42)
        btnDaftar.TabIndex = 2
        btnDaftar.Text = "Daftar"
        btnDaftar.UseVisualStyleBackColor = False
        ' 
        ' txtKonfirmasi
        ' 
        txtKonfirmasi.BorderStyle = BorderStyle.None
        txtKonfirmasi.Font = New Font("Segoe UI", 14.25F)
        txtKonfirmasi.Location = New Point(898, 479)
        txtKonfirmasi.Name = "txtKonfirmasi"
        txtKonfirmasi.PasswordChar = "*"c
        txtKonfirmasi.PlaceholderText = "Konfirmasi Password"
        txtKonfirmasi.Size = New Size(368, 26)
        txtKonfirmasi.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Font = New Font("Segoe UI", 14.25F)
        txtPassword.Location = New Point(898, 368)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.PlaceholderText = "Password"
        txtPassword.Size = New Size(368, 26)
        txtPassword.TabIndex = 5
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.Font = New Font("Segoe UI", 14.25F)
        txtUsername.Location = New Point(898, 256)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Username"
        txtUsername.Size = New Size(368, 26)
        txtUsername.TabIndex = 7
        ' 
        ' FormRegister
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(250))
        BackgroundImage = My.Resources.Resources.genshin__daftar
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1404, 768)
        Controls.Add(chkShowPassword)
        Controls.Add(btnBatal)
        Controls.Add(btnDaftar)
        Controls.Add(txtKonfirmasi)
        Controls.Add(txtUsername)
        Controls.Add(txtPassword)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FormRegister"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Daftar Akun - Joki Genshin"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtKonfirmasi As System.Windows.Forms.TextBox
    Friend WithEvents chkShowPassword As System.Windows.Forms.CheckBox
    Friend WithEvents btnDaftar As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button

End Class
