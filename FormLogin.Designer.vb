<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        btnBatal = New Button()
        chkShowPassword = New CheckBox()
        lblRegister = New Label()
        lblAkunBaru = New Label()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(899, 308)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Username"
        txtUsername.Size = New Size(373, 28)
        txtUsername.TabIndex = 7
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(899, 417)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.PlaceholderText = "Password"
        txtPassword.Size = New Size(373, 28)
        txtPassword.TabIndex = 5
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        btnLogin.Cursor = Cursors.Hand
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(884, 548)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(242, 38)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Masuk"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        btnBatal.Cursor = Cursors.Hand
        btnBatal.FlatAppearance.BorderSize = 0
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(1148, 548)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(137, 38)
        btnBatal.TabIndex = 3
        btnBatal.Text = "Keluar"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.BackColor = Color.Transparent
        chkShowPassword.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkShowPassword.ForeColor = Color.White
        chkShowPassword.Location = New Point(899, 499)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(185, 25)
        chkShowPassword.TabIndex = 2
        chkShowPassword.Text = "Tampilkan Password"
        chkShowPassword.UseVisualStyleBackColor = False
        ' 
        ' lblRegister
        ' 
        lblRegister.BackColor = Color.Transparent
        lblRegister.Cursor = Cursors.Hand
        lblRegister.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblRegister.ForeColor = Color.Blue
        lblRegister.Location = New Point(1078, 615)
        lblRegister.Name = "lblRegister"
        lblRegister.Size = New Size(178, 31)
        lblRegister.TabIndex = 1
        lblRegister.Text = "Daftar disini"
        ' 
        ' lblAkunBaru
        ' 
        lblAkunBaru.BackColor = Color.Transparent
        lblAkunBaru.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAkunBaru.ForeColor = Color.White
        lblAkunBaru.Location = New Point(884, 615)
        lblAkunBaru.Name = "lblAkunBaru"
        lblAkunBaru.Size = New Size(198, 32)
        lblAkunBaru.TabIndex = 0
        lblAkunBaru.Text = "Belum punya akun?"
        ' 
        ' FormLogin
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(250))
        BackgroundImage = My.Resources.Resources.genshin_login3
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1404, 768)
        Controls.Add(lblAkunBaru)
        Controls.Add(lblRegister)
        Controls.Add(chkShowPassword)
        Controls.Add(btnBatal)
        Controls.Add(txtUsername)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FormLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login - Joki Genshin"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents lblRegister As Label
    Friend WithEvents lblAkunBaru As Label

End Class