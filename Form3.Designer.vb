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
        btnCetakStruk = New Button()
        Label3 = New Label()
        cmbMetodeBayar = New ComboBox()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvJokiUser, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblHarga
        ' 
        lblHarga.BackColor = Color.Transparent
        lblHarga.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHarga.ForeColor = Color.Black
        lblHarga.Location = New Point(14, 400)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(531, 60)
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
        Label2.Location = New Point(11, 196)
        Label2.Name = "Label2"
        Label2.Size = New Size(194, 40)
        Label2.TabIndex = 37
        Label2.Text = "Character/Map/Event"
        ' 
        ' txtDetail
        ' 
        txtDetail.Location = New Point(304, 193)
        txtDetail.Margin = New Padding(3, 4, 3, 4)
        txtDetail.Name = "txtDetail"
        txtDetail.Size = New Size(228, 27)
        txtDetail.TabIndex = 38
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(11, 313)
        Label1.Name = "Label1"
        Label1.Size = New Size(210, 23)
        Label1.TabIndex = 36
        Label1.Text = "Tingkat Kesulitan"
        ' 
        ' LabelUID
        ' 
        LabelUID.BackColor = Color.Transparent
        LabelUID.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        LabelUID.ForeColor = Color.Black
        LabelUID.Location = New Point(14, 24)
        LabelUID.Name = "LabelUID"
        LabelUID.Size = New Size(114, 31)
        LabelUID.TabIndex = 27
        LabelUID.Text = "UID Game"
        ' 
        ' txtUID
        ' 
        txtUID.Location = New Point(243, 21)
        txtUID.Margin = New Padding(3, 4, 3, 4)
        txtUID.Name = "txtUID"
        txtUID.Size = New Size(289, 27)
        txtUID.TabIndex = 28
        ' 
        ' LabelUser
        ' 
        LabelUser.BackColor = Color.Transparent
        LabelUser.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        LabelUser.ForeColor = Color.Black
        LabelUser.Location = New Point(11, 88)
        LabelUser.Name = "LabelUser"
        LabelUser.Size = New Size(194, 47)
        LabelUser.TabIndex = 29
        LabelUser.Text = "Username/Email"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(243, 75)
        txtUsername.Margin = New Padding(3, 4, 3, 4)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(289, 27)
        txtUsername.TabIndex = 30
        ' 
        ' LabelPass
        ' 
        LabelPass.BackColor = Color.Transparent
        LabelPass.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        LabelPass.ForeColor = Color.Black
        LabelPass.Location = New Point(11, 141)
        LabelPass.Name = "LabelPass"
        LabelPass.Size = New Size(114, 31)
        LabelPass.TabIndex = 31
        LabelPass.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(243, 132)
        txtPassword.Margin = New Padding(3, 4, 3, 4)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(289, 27)
        txtPassword.TabIndex = 32
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' LabelLayanan
        ' 
        LabelLayanan.BackColor = Color.Transparent
        LabelLayanan.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        LabelLayanan.ForeColor = Color.Black
        LabelLayanan.Location = New Point(11, 256)
        LabelLayanan.Name = "LabelLayanan"
        LabelLayanan.Size = New Size(179, 44)
        LabelLayanan.TabIndex = 33
        LabelLayanan.Text = "Pilih Layanan"
        ' 
        ' cmbLayanan
        ' 
        cmbLayanan.DropDownStyle = ComboBoxStyle.DropDownList
        cmbLayanan.Location = New Point(243, 253)
        cmbLayanan.Margin = New Padding(3, 4, 3, 4)
        cmbLayanan.Name = "cmbLayanan"
        cmbLayanan.Size = New Size(289, 28)
        cmbLayanan.TabIndex = 34
        ' 
        ' cmbKesulitan
        ' 
        cmbKesulitan.DropDownStyle = ComboBoxStyle.DropDownList
        cmbKesulitan.Items.AddRange(New Object() {"1", "2", "3"})
        cmbKesulitan.Location = New Point(243, 311)
        cmbKesulitan.Margin = New Padding(3, 4, 3, 4)
        cmbKesulitan.Name = "cmbKesulitan"
        cmbKesulitan.Size = New Size(285, 28)
        cmbKesulitan.TabIndex = 35
        ' 
        ' btnPesan
        ' 
        btnPesan.BackColor = Color.DarkRed
        btnPesan.Font = New Font("Microsoft Sans Serif", 9F)
        btnPesan.ForeColor = Color.White
        btnPesan.Location = New Point(7, 464)
        btnPesan.Margin = New Padding(3, 4, 3, 4)
        btnPesan.Name = "btnPesan"
        btnPesan.Size = New Size(175, 61)
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
        btnBatal.Location = New Point(188, 464)
        btnBatal.Margin = New Padding(3, 4, 3, 4)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(180, 61)
        btnBatal.TabIndex = 41
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' dgvJokiUser
        ' 
        dgvJokiUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvJokiUser.Location = New Point(7, 533)
        dgvJokiUser.Margin = New Padding(3, 4, 3, 4)
        dgvJokiUser.Name = "dgvJokiUser"
        dgvJokiUser.RowHeadersWidth = 51
        dgvJokiUser.Size = New Size(531, 196)
        dgvJokiUser.TabIndex = 42
        ' 
        ' btnCetakStruk
        ' 
        btnCetakStruk.BackColor = Color.DarkRed
        btnCetakStruk.Font = New Font("Microsoft Sans Serif", 9F)
        btnCetakStruk.ForeColor = Color.White
        btnCetakStruk.Location = New Point(370, 464)
        btnCetakStruk.Margin = New Padding(3, 4, 3, 4)
        btnCetakStruk.Name = "btnCetakStruk"
        btnCetakStruk.Size = New Size(175, 61)
        btnCetakStruk.TabIndex = 43
        btnCetakStruk.Text = "Cetak"
        btnCetakStruk.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(14, 372)
        Label3.Name = "Label3"
        Label3.Size = New Size(231, 44)
        Label3.TabIndex = 44
        Label3.Text = "Metode Pembayaran"
        ' 
        ' cmbMetodeBayar
        ' 
        cmbMetodeBayar.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMetodeBayar.Items.AddRange(New Object() {"1", "2", "3"})
        cmbMetodeBayar.Location = New Point(243, 368)
        cmbMetodeBayar.Margin = New Padding(3, 4, 3, 4)
        cmbMetodeBayar.Name = "cmbMetodeBayar"
        cmbMetodeBayar.Size = New Size(285, 28)
        cmbMetodeBayar.TabIndex = 45
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(550, 742)
        Controls.Add(cmbMetodeBayar)
        Controls.Add(Label3)
        Controls.Add(btnCetakStruk)
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
        Margin = New Padding(3, 4, 3, 4)
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
    Friend WithEvents btnCetakStruk As Button
    Friend WithEvents cmbMetodeBayar As ComboBox
    Friend WithEvents Label3 As Label
End Class
