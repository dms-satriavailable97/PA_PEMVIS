<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblHarga = New Label()
        Label2 = New Label()
        txtDetail = New TextBox()
        Label1 = New Label()
        LabelUID = New Label()
        txtUID = New TextBox()
        LabelUser = New Label()
        txtUsername = New TextBox()
        LabelPass = New Label()
        txtPassword = New TextBox()
        LabelLayanan = New Label()
        cmbLayanan = New ComboBox()
        cmbKesulitan = New ComboBox()
        btnPesan = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        btnBatal = New Button()
        dgvJokiUser = New DataGridView()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvJokiUser, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblHarga
        ' 
        lblHarga.BackColor = Color.Transparent
        lblHarga.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHarga.ForeColor = Color.Black
        lblHarga.Location = New Point(12, 269)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(465, 45)
        lblHarga.TabIndex = 39
        lblHarga.Text = "PLACEHOLDER HARGA"
        lblHarga.TextAlign = ContentAlignment.MiddleCenter
        lblHarga.Visible = False
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(10, 147)
        Label2.Name = "Label2"
        Label2.Size = New Size(170, 30)
        Label2.TabIndex = 37
        Label2.Text = "Character/Map/Event"
        ' 
        ' txtDetail
        ' 
        txtDetail.Location = New Point(266, 145)
        txtDetail.Name = "txtDetail"
        txtDetail.Size = New Size(200, 23)
        txtDetail.TabIndex = 38
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(10, 235)
        Label1.Name = "Label1"
        Label1.Size = New Size(184, 17)
        Label1.TabIndex = 36
        Label1.Text = "Tingkat Kesulitan"
        ' 
        ' LabelUID
        ' 
        LabelUID.BackColor = Color.Transparent
        LabelUID.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        LabelUID.ForeColor = Color.Black
        LabelUID.Location = New Point(12, 18)
        LabelUID.Name = "LabelUID"
        LabelUID.Size = New Size(100, 23)
        LabelUID.TabIndex = 27
        LabelUID.Text = "UID Game"
        ' 
        ' txtUID
        ' 
        txtUID.Location = New Point(213, 16)
        txtUID.Name = "txtUID"
        txtUID.Size = New Size(253, 23)
        txtUID.TabIndex = 28
        ' 
        ' LabelUser
        ' 
        LabelUser.BackColor = Color.Transparent
        LabelUser.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        LabelUser.ForeColor = Color.Black
        LabelUser.Location = New Point(10, 66)
        LabelUser.Name = "LabelUser"
        LabelUser.Size = New Size(170, 35)
        LabelUser.TabIndex = 29
        LabelUser.Text = "Username/Email"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(213, 56)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(253, 23)
        txtUsername.TabIndex = 30
        ' 
        ' LabelPass
        ' 
        LabelPass.BackColor = Color.Transparent
        LabelPass.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        LabelPass.ForeColor = Color.Black
        LabelPass.Location = New Point(10, 106)
        LabelPass.Name = "LabelPass"
        LabelPass.Size = New Size(100, 23)
        LabelPass.TabIndex = 31
        LabelPass.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(213, 99)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(253, 23)
        txtPassword.TabIndex = 32
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' LabelLayanan
        ' 
        LabelLayanan.BackColor = Color.Transparent
        LabelLayanan.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        LabelLayanan.ForeColor = Color.Black
        LabelLayanan.Location = New Point(10, 192)
        LabelLayanan.Name = "LabelLayanan"
        LabelLayanan.Size = New Size(157, 33)
        LabelLayanan.TabIndex = 33
        LabelLayanan.Text = "Pilih Layanan"
        ' 
        ' cmbLayanan
        ' 
        cmbLayanan.DropDownStyle = ComboBoxStyle.DropDownList
        cmbLayanan.Location = New Point(213, 190)
        cmbLayanan.Name = "cmbLayanan"
        cmbLayanan.Size = New Size(253, 23)
        cmbLayanan.TabIndex = 34
        ' 
        ' cmbKesulitan
        ' 
        cmbKesulitan.DropDownStyle = ComboBoxStyle.DropDownList
        cmbKesulitan.Items.AddRange(New Object() {"1", "2", "3"})
        cmbKesulitan.Location = New Point(213, 233)
        cmbKesulitan.Name = "cmbKesulitan"
        cmbKesulitan.Size = New Size(250, 23)
        cmbKesulitan.TabIndex = 35
        ' 
        ' btnPesan
        ' 
        btnPesan.BackColor = Color.DarkRed
        btnPesan.Font = New Font("Microsoft Sans Serif", 9F)
        btnPesan.ForeColor = Color.White
        btnPesan.Location = New Point(8, 317)
        btnPesan.Name = "btnPesan"
        btnPesan.Size = New Size(228, 46)
        btnPesan.TabIndex = 40
        btnPesan.Text = "Pesan"
        btnPesan.UseVisualStyleBackColor = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.DarkRed
        btnBatal.Font = New Font("Microsoft Sans Serif", 9F)
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(244, 317)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(229, 46)
        btnBatal.TabIndex = 41
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' dgvJokiUser
        ' 
        dgvJokiUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvJokiUser.Location = New Point(8, 369)
        dgvJokiUser.Name = "dgvJokiUser"
        dgvJokiUser.Size = New Size(465, 147)
        dgvJokiUser.TabIndex = 42
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(481, 522)
        Controls.Add(dgvJokiUser)
        Controls.Add(btnBatal)
        Controls.Add(btnPesan)
        Controls.Add(lblHarga)
        Controls.Add(Label2)
        Controls.Add(txtDetail)
        Controls.Add(Label1)
        Controls.Add(LabelUID)
        Controls.Add(txtUID)
        Controls.Add(LabelUser)
        Controls.Add(txtUsername)
        Controls.Add(LabelPass)
        Controls.Add(txtPassword)
        Controls.Add(LabelLayanan)
        Controls.Add(cmbLayanan)
        Controls.Add(cmbKesulitan)
        Name = "Form3"
        Text = "Form3"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvJokiUser, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHarga As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDetail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelUID As Label
    Friend WithEvents txtUID As TextBox
    Friend WithEvents LabelUser As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents LabelPass As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents LabelLayanan As Label
    Friend WithEvents cmbLayanan As ComboBox
    Friend WithEvents cmbKesulitan As ComboBox
    Friend WithEvents btnPesan As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnBatal As Button
    Friend WithEvents dgvJokiUser As DataGridView
End Class
