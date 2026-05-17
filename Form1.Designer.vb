<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        LabelUID = New Label()
        LabelUser = New Label()
        LabelPass = New Label()
        LabelLayanan = New Label()
        txtUID = New TextBox()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        cmbLayanan = New ComboBox()
        cmbKesulitan = New ComboBox()
        dgvJoki = New DataGridView()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        btnMasterLayanan = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        txtSearch = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        txtDetail = New TextBox()
        LabelSulit = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        btnLihatPendapatan = New Button()
        btnSelesai = New Button()
        lblHarga = New Label()
        CType(dgvJoki, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LabelUID
        ' 
        LabelUID.BackColor = Color.Transparent
        LabelUID.Font = New Font("Magic R", 9.0F, FontStyle.Bold)
        LabelUID.ForeColor = Color.White
        LabelUID.Location = New Point(12, 20)
        LabelUID.Name = "LabelUID"
        LabelUID.Size = New Size(100, 23)
        LabelUID.TabIndex = 0
        LabelUID.Text = "UID Game"
        ' 
        ' LabelUser
        ' 
        LabelUser.BackColor = Color.Transparent
        LabelUser.Font = New Font("Magic R", 9.0F, FontStyle.Bold)
        LabelUser.ForeColor = Color.White
        LabelUser.Location = New Point(11, 63)
        LabelUser.Name = "LabelUser"
        LabelUser.Size = New Size(170, 35)
        LabelUser.TabIndex = 2
        LabelUser.Text = "Username/Email"
        ' 
        ' LabelPass
        ' 
        LabelPass.BackColor = Color.Transparent
        LabelPass.Font = New Font("Magic R", 9.0F, FontStyle.Bold)
        LabelPass.ForeColor = Color.White
        LabelPass.Location = New Point(11, 103)
        LabelPass.Name = "LabelPass"
        LabelPass.Size = New Size(100, 23)
        LabelPass.TabIndex = 4
        LabelPass.Text = "Password"
        ' 
        ' LabelLayanan
        ' 
        LabelLayanan.BackColor = Color.Transparent
        LabelLayanan.Font = New Font("Magic R", 9.0F, FontStyle.Bold)
        LabelLayanan.ForeColor = Color.White
        LabelLayanan.Location = New Point(11, 189)
        LabelLayanan.Name = "LabelLayanan"
        LabelLayanan.Size = New Size(157, 33)
        LabelLayanan.TabIndex = 6
        LabelLayanan.Text = "Pilih Layanan"
        ' 
        ' txtUID
        ' 
        txtUID.Location = New Point(214, 12)
        txtUID.Name = "txtUID"
        txtUID.Size = New Size(253, 31)
        txtUID.TabIndex = 1
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(214, 52)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(253, 31)
        txtUsername.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(214, 95)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(253, 31)
        txtPassword.TabIndex = 5
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' cmbLayanan
        ' 
        cmbLayanan.DropDownStyle = ComboBoxStyle.DropDownList
        cmbLayanan.Location = New Point(214, 186)
        cmbLayanan.Name = "cmbLayanan"
        cmbLayanan.Size = New Size(253, 33)
        cmbLayanan.TabIndex = 7
        ' 
        ' cmbKesulitan
        ' 
        cmbKesulitan.DropDownStyle = ComboBoxStyle.DropDownList
        cmbKesulitan.Items.AddRange(New Object() {"1", "2", "3"})
        cmbKesulitan.Location = New Point(214, 229)
        cmbKesulitan.Name = "cmbKesulitan"
        cmbKesulitan.Size = New Size(250, 33)
        cmbKesulitan.TabIndex = 9
        ' 
        ' dgvJoki
        ' 
        dgvJoki.BackgroundColor = Color.DarkRed
        dgvJoki.ColumnHeadersHeight = 34
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = Color.Red
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        dgvJoki.DefaultCellStyle = DataGridViewCellStyle1
        dgvJoki.Location = New Point(20, 396)
        dgvJoki.Name = "dgvJoki"
        dgvJoki.ReadOnly = True
        dgvJoki.RowHeadersWidth = 62
        dgvJoki.Size = New Size(671, 205)
        dgvJoki.TabIndex = 15
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.DarkRed
        btnSimpan.Font = New Font("Magic R", 9.0F)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(20, 344)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(95, 46)
        btnSimpan.TabIndex = 10
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.DarkRed
        btnUbah.Font = New Font("Magic R", 9.0F)
        btnUbah.ForeColor = Color.White
        btnUbah.Location = New Point(140, 344)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(95, 46)
        btnUbah.TabIndex = 11
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.DarkRed
        btnHapus.Font = New Font("Magic R", 9.0F)
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(258, 344)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(95, 46)
        btnHapus.TabIndex = 12
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.DarkRed
        btnBatal.Font = New Font("Magic R", 9.0F)
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(372, 344)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(95, 46)
        btnBatal.TabIndex = 13
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' btnMasterLayanan
        ' 
        btnMasterLayanan.BackColor = Color.DarkRed
        btnMasterLayanan.Font = New Font("Magic R", 9.0F)
        btnMasterLayanan.ForeColor = SystemColors.Control
        btnMasterLayanan.Location = New Point(683, 12)
        btnMasterLayanan.Name = "btnMasterLayanan"
        btnMasterLayanan.Size = New Size(300, 59)
        btnMasterLayanan.TabIndex = 14
        btnMasterLayanan.Text = "Kelola Layanan"
        btnMasterLayanan.UseVisualStyleBackColor = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(214, 297)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(253, 31)
        txtSearch.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Magic R", 9.0F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(11, 232)
        Label1.Name = "Label1"
        Label1.Size = New Size(184, 17)
        Label1.TabIndex = 17
        Label1.Text = "Tingkat Kesulitan"
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Magic R", 9.0F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(11, 144)
        Label2.Name = "Label2"
        Label2.Size = New Size(250, 30)
        Label2.TabIndex = 18
        Label2.Text = "Character /Map /Event"
        ' 
        ' txtDetail
        ' 
        txtDetail.Location = New Point(267, 141)
        txtDetail.Name = "txtDetail"
        txtDetail.Size = New Size(200, 31)
        txtDetail.TabIndex = 19
        ' 
        ' LabelSulit
        ' 
        LabelSulit.BackColor = Color.Transparent
        LabelSulit.Font = New Font("Magic R", 9.0F, FontStyle.Bold)
        LabelSulit.ForeColor = Color.White
        LabelSulit.Location = New Point(11, 300)
        LabelSulit.Name = "LabelSulit"
        LabelSulit.Size = New Size(142, 28)
        LabelSulit.TabIndex = 8
        LabelSulit.Text = "Cari"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources._transparent_render__genshin_birthday_klee_1_by_dawnofragnvindr_dfgfpg9_pre
        PictureBox1.Location = New Point(697, 320)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(370, 358)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 20
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.genshin_klee_yelling_512x512
        PictureBox2.Location = New Point(498, 9)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(179, 163)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 21
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = My.Resources.Resources.image_1775972619438
        PictureBox3.Location = New Point(712, 95)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(271, 205)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 22
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = My.Resources.Resources.image_1775972612373
        PictureBox4.Location = New Point(498, 186)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(193, 201)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 23
        PictureBox4.TabStop = False
        ' 
        ' btnLihatPendapatan
        ' 
        btnLihatPendapatan.BackColor = Color.DarkRed
        btnLihatPendapatan.Font = New Font("Magic R", 9.0F)
        btnLihatPendapatan.ForeColor = SystemColors.Control
        btnLihatPendapatan.Location = New Point(372, 607)
        btnLihatPendapatan.Name = "btnLihatPendapatan"
        btnLihatPendapatan.Size = New Size(319, 46)
        btnLihatPendapatan.TabIndex = 24
        btnLihatPendapatan.Text = "Lihat Pendapatan"
        btnLihatPendapatan.UseVisualStyleBackColor = False
        ' 
        ' btnSelesai
        ' 
        btnSelesai.BackColor = Color.DarkRed
        btnSelesai.Font = New Font("Magic R", 9.0F)
        btnSelesai.ForeColor = SystemColors.Control
        btnSelesai.Location = New Point(20, 607)
        btnSelesai.Name = "btnSelesai"
        btnSelesai.Size = New Size(342, 46)
        btnSelesai.TabIndex = 25
        btnSelesai.Text = "Update Selesai"
        btnSelesai.UseVisualStyleBackColor = False
        ' 
        ' lblHarga
        ' 
        lblHarga.BackColor = Color.Transparent
        lblHarga.Font = New Font("Magic R", 9.0F, FontStyle.Bold)
        lblHarga.ForeColor = Color.White
        lblHarga.Location = New Point(214, 270)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(184, 17)
        lblHarga.TabIndex = 26
        lblHarga.Text = "Tingkat Kesulitan"
        lblHarga.Visible = False
        ' 
        ' Form1
        ' 
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1009, 665)
        Controls.Add(lblHarga)
        Controls.Add(btnSelesai)
        Controls.Add(btnLihatPendapatan)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(txtDetail)
        Controls.Add(Label1)
        Controls.Add(txtSearch)
        Controls.Add(LabelUID)
        Controls.Add(txtUID)
        Controls.Add(LabelUser)
        Controls.Add(txtUsername)
        Controls.Add(LabelPass)
        Controls.Add(txtPassword)
        Controls.Add(LabelLayanan)
        Controls.Add(cmbLayanan)
        Controls.Add(LabelSulit)
        Controls.Add(cmbKesulitan)
        Controls.Add(btnSimpan)
        Controls.Add(btnUbah)
        Controls.Add(btnHapus)
        Controls.Add(btnBatal)
        Controls.Add(btnMasterLayanan)
        Controls.Add(dgvJoki)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Input Antrean Joki Genshin"
        CType(dgvJoki, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents LabelUID As Label
    Friend WithEvents LabelUser As Label
    Friend WithEvents LabelPass As Label
    Friend WithEvents LabelLayanan As Label
    Friend WithEvents txtUID As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents cmbLayanan As ComboBox
    Friend WithEvents cmbKesulitan As ComboBox
    Friend WithEvents dgvJoki As DataGridView
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnMasterLayanan As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDetail As TextBox
    Friend WithEvents LabelSulit As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnSelesai As Button
    Friend WithEvents btnLihatPendapatan As Button
    Friend WithEvents lblHarga As Label
End Class