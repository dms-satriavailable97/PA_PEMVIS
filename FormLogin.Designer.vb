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
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlForm = New System.Windows.Forms.Panel()
        Me.lblRegister = New System.Windows.Forms.Label()
        Me.lblAkunBaru = New System.Windows.Forms.Label()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.pnlForm.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()

        ' pnlMain
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(245, 245, 250)
        Me.pnlMain.Controls.Add(Me.pnlForm)
        Me.pnlMain.Controls.Add(Me.pnlHeader)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Size = New System.Drawing.Size(420, 540)

        ' pnlHeader
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(52, 73, 94)
        Me.pnlHeader.Controls.Add(Me.lblSubTitle)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Size = New System.Drawing.Size(420, 120)

        ' lblTitle
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 22, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 25)
        Me.lblTitle.Size = New System.Drawing.Size(420, 45)
        Me.lblTitle.Text = "Joki Genshin Impact"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' lblSubTitle
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(189, 195, 199)
        Me.lblSubTitle.Location = New System.Drawing.Point(0, 72)
        Me.lblSubTitle.Size = New System.Drawing.Size(420, 30)
        Me.lblSubTitle.Text = "Silakan masuk untuk melanjutkan"
        Me.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' pnlForm
        Me.pnlForm.BackColor = System.Drawing.Color.White
        Me.pnlForm.Controls.Add(Me.lblAkunBaru)
        Me.pnlForm.Controls.Add(Me.lblRegister)
        Me.pnlForm.Controls.Add(Me.chkShowPassword)
        Me.pnlForm.Controls.Add(Me.btnBatal)
        Me.pnlForm.Controls.Add(Me.btnLogin)
        Me.pnlForm.Controls.Add(Me.txtPassword)
        Me.pnlForm.Controls.Add(Me.lblPassword)
        Me.pnlForm.Controls.Add(Me.txtUsername)
        Me.pnlForm.Controls.Add(Me.lblUsername)
        Me.pnlForm.Controls.Add(Me.lblFormTitle)
        Me.pnlForm.Location = New System.Drawing.Point(30, 140)
        Me.pnlForm.Size = New System.Drawing.Size(360, 370)
        Me.pnlForm.BackColor = System.Drawing.Color.White
        Me.pnlForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle

        ' lblFormTitle
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI", 13, System.Drawing.FontStyle.Bold)
        Me.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94)
        Me.lblFormTitle.Location = New System.Drawing.Point(20, 18)
        Me.lblFormTitle.Size = New System.Drawing.Size(320, 30)
        Me.lblFormTitle.Text = "Login"

        ' lblUsername
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80)
        Me.lblUsername.Location = New System.Drawing.Point(20, 60)
        Me.lblUsername.Size = New System.Drawing.Size(320, 20)
        Me.lblUsername.Text = "Username"

        ' txtUsername
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.txtUsername.Location = New System.Drawing.Point(20, 82)
        Me.txtUsername.Size = New System.Drawing.Size(320, 28)
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle

        ' lblPassword
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80)
        Me.lblPassword.Location = New System.Drawing.Point(20, 125)
        Me.lblPassword.Size = New System.Drawing.Size(320, 20)
        Me.lblPassword.Text = "Password"

        ' txtPassword
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.txtPassword.Location = New System.Drawing.Point(20, 147)
        Me.txtPassword.PasswordChar = "*"c
        Me.txtPassword.Size = New System.Drawing.Size(320, 28)
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle

        ' chkShowPassword
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Font = New System.Drawing.Font("Segoe UI", 8.5)
        Me.chkShowPassword.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100)
        Me.chkShowPassword.Location = New System.Drawing.Point(20, 183)
        Me.chkShowPassword.Size = New System.Drawing.Size(120, 20)
        Me.chkShowPassword.Text = "Tampilkan Password"

        ' btnLogin
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(52, 152, 219)
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(20, 215)
        Me.btnLogin.Size = New System.Drawing.Size(320, 38)
        Me.btnLogin.Text = "Masuk"
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand

        ' btnBatal
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(231, 76, 60)
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        Me.btnBatal.ForeColor = System.Drawing.Color.White
        Me.btnBatal.Location = New System.Drawing.Point(20, 263)
        Me.btnBatal.Size = New System.Drawing.Size(320, 38)
        Me.btnBatal.Text = "Keluar"
        Me.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand

        ' lblAkunBaru
        Me.lblAkunBaru.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblAkunBaru.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100)
        Me.lblAkunBaru.Location = New System.Drawing.Point(20, 318)
        Me.lblAkunBaru.Size = New System.Drawing.Size(160, 22)
        Me.lblAkunBaru.Text = "Belum punya akun?"

        ' lblRegister
        Me.lblRegister.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline)
        Me.lblRegister.ForeColor = System.Drawing.Color.FromArgb(52, 152, 219)
        Me.lblRegister.Location = New System.Drawing.Point(178, 318)
        Me.lblRegister.Size = New System.Drawing.Size(80, 22)
        Me.lblRegister.Text = "Daftar disini"
        Me.lblRegister.Cursor = System.Windows.Forms.Cursors.Hand

        ' FormLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(245, 245, 250)
        Me.ClientSize = New System.Drawing.Size(420, 540)
        Me.Controls.Add(Me.pnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login - Joki Genshin"

        Me.pnlHeader.ResumeLayout(False)
        Me.pnlForm.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)
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
    Friend WithEvents chkShowPassword As System.Windows.Forms.CheckBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents lblAkunBaru As System.Windows.Forms.Label
    Friend WithEvents lblRegister As System.Windows.Forms.Label

End Class