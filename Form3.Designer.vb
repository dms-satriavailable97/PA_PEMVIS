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
        Label4 = New Label()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvJokiUser, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblHarga
        ' 
        lblHarga.BackColor = Color.Transparent
        lblHarga.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHarga.ForeColor = Color.Black
        lblHarga.Location = New Point(71, 528)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(395, 45)
        lblHarga.TabIndex = 39
        lblHarga.Text = "PLACEHOLDER HARGA"
        lblHarga.TextAlign = ContentAlignment.MiddleLeft
        lblHarga.Visible = False
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(221), CByte(76), CByte(45))
        Label2.Location = New Point(71, 372)
        Label2.Name = "Label2"
        Label2.Size = New Size(170, 30)
        Label2.TabIndex = 37
        Label2.Text = "Character/Map/Event"
        ' 
        ' txtDetail
        ' 
        txtDetail.Location = New Point(272, 372)
        txtDetail.Name = "txtDetail"
        txtDetail.Size = New Size(450, 23)
        txtDetail.TabIndex = 38
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(221), CByte(76), CByte(45))
        Label1.Location = New Point(71, 450)
        Label1.Name = "Label1"
        Label1.Size = New Size(184, 17)
        Label1.TabIndex = 36
        Label1.Text = "Tingkat Kesulitan"
        ' 
        ' LabelUID
        ' 
        LabelUID.BackColor = Color.Transparent
        LabelUID.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        LabelUID.ForeColor = Color.FromArgb(CByte(221), CByte(76), CByte(45))
        LabelUID.Location = New Point(71, 258)
        LabelUID.Name = "LabelUID"
        LabelUID.Size = New Size(100, 23)
        LabelUID.TabIndex = 27
        LabelUID.Text = "UID Game"
        ' 
        ' txtUID
        ' 
        txtUID.Location = New Point(272, 258)
        txtUID.Name = "txtUID"
        txtUID.Size = New Size(450, 23)
        txtUID.TabIndex = 28
        ' 
        ' LabelUser
        ' 
        LabelUser.BackColor = Color.Transparent
        LabelUser.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        LabelUser.ForeColor = Color.FromArgb(CByte(221), CByte(76), CByte(45))
        LabelUser.Location = New Point(71, 294)
        LabelUser.Name = "LabelUser"
        LabelUser.Size = New Size(170, 35)
        LabelUser.TabIndex = 29
        LabelUser.Text = "Username/Email"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(272, 294)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(450, 23)
        txtUsername.TabIndex = 30
        ' 
        ' LabelPass
        ' 
        LabelPass.BackColor = Color.Transparent
        LabelPass.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        LabelPass.ForeColor = Color.FromArgb(CByte(221), CByte(76), CByte(45))
        LabelPass.Location = New Point(71, 332)
        LabelPass.Name = "LabelPass"
        LabelPass.Size = New Size(100, 23)
        LabelPass.TabIndex = 31
        LabelPass.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(272, 332)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(450, 23)
        txtPassword.TabIndex = 32
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' LabelLayanan
        ' 
        LabelLayanan.BackColor = Color.Transparent
        LabelLayanan.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        LabelLayanan.ForeColor = Color.FromArgb(CByte(221), CByte(76), CByte(45))
        LabelLayanan.Location = New Point(71, 410)
        LabelLayanan.Name = "LabelLayanan"
        LabelLayanan.Size = New Size(157, 33)
        LabelLayanan.TabIndex = 33
        LabelLayanan.Text = "Pilih Layanan"
        ' 
        ' cmbLayanan
        ' 
        cmbLayanan.BackColor = Color.White
        cmbLayanan.DropDownStyle = ComboBoxStyle.DropDownList
        cmbLayanan.Location = New Point(272, 409)
        cmbLayanan.Name = "cmbLayanan"
        cmbLayanan.Size = New Size(253, 23)
        cmbLayanan.TabIndex = 34
        ' 
        ' cmbKesulitan
        ' 
        cmbKesulitan.DropDownStyle = ComboBoxStyle.DropDownList
        cmbKesulitan.Items.AddRange(New Object() {"1", "2", "3"})
        cmbKesulitan.Location = New Point(272, 450)
        cmbKesulitan.Name = "cmbKesulitan"
        cmbKesulitan.Size = New Size(250, 23)
        cmbKesulitan.TabIndex = 35
        ' 
        ' btnPesan
        ' 
        btnPesan.BackColor = Color.Transparent
        btnPesan.BackgroundImage = My.Resources.Resources.button_simpan
        btnPesan.BackgroundImageLayout = ImageLayout.Zoom
        btnPesan.FlatStyle = FlatStyle.Flat
        btnPesan.Font = New Font("Microsoft Sans Serif", 9F)
        btnPesan.ForeColor = Color.White
        btnPesan.Location = New Point(472, 534)
        btnPesan.Name = "btnPesan"
        btnPesan.Size = New Size(112, 35)
        btnPesan.TabIndex = 40
        btnPesan.UseVisualStyleBackColor = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.Transparent
        btnBatal.BackgroundImage = My.Resources.Resources.button_batal
        btnBatal.BackgroundImageLayout = ImageLayout.Zoom
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Microsoft Sans Serif", 9F)
        btnBatal.ForeColor = Color.Transparent
        btnBatal.Location = New Point(708, 534)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(112, 35)
        btnBatal.TabIndex = 41
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' dgvJokiUser
        ' 
        dgvJokiUser.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvJokiUser.BackgroundColor = Color.White
        dgvJokiUser.BorderStyle = BorderStyle.Fixed3D
        dgvJokiUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvJokiUser.GridColor = Color.Black
        dgvJokiUser.Location = New Point(65, 577)
        dgvJokiUser.Name = "dgvJokiUser"
        dgvJokiUser.ReadOnly = True
        dgvJokiUser.RowHeadersWidth = 51
        dgvJokiUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvJokiUser.Size = New Size(767, 106)
        dgvJokiUser.TabIndex = 42
        ' 
        ' btnCetakStruk
        ' 
        btnCetakStruk.BackColor = Color.Transparent
        btnCetakStruk.BackgroundImage = My.Resources.Resources.button_cetak
        btnCetakStruk.BackgroundImageLayout = ImageLayout.Zoom
        btnCetakStruk.FlatStyle = FlatStyle.Flat
        btnCetakStruk.Font = New Font("Microsoft Sans Serif", 9F)
        btnCetakStruk.ForeColor = Color.Transparent
        btnCetakStruk.Location = New Point(590, 534)
        btnCetakStruk.Name = "btnCetakStruk"
        btnCetakStruk.Size = New Size(112, 35)
        btnCetakStruk.TabIndex = 43
        btnCetakStruk.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(221), CByte(76), CByte(45))
        Label3.Location = New Point(71, 491)
        Label3.Name = "Label3"
        Label3.Size = New Size(202, 33)
        Label3.TabIndex = 44
        Label3.Text = "Metode Pembayaran"
        ' 
        ' cmbMetodeBayar
        ' 
        cmbMetodeBayar.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMetodeBayar.Items.AddRange(New Object() {"1", "2", "3"})
        cmbMetodeBayar.Location = New Point(272, 491)
        cmbMetodeBayar.Name = "cmbMetodeBayar"
        cmbMetodeBayar.Size = New Size(250, 23)
        cmbMetodeBayar.TabIndex = 45
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Monotype Corsiva", 36F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(224, 166)
        Label4.Name = "Label4"
        Label4.Size = New Size(456, 83)
        Label4.TabIndex = 46
        Label4.Text = "Form Pemesanan"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.genshin_degen
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1335, 777)
        Controls.Add(Label4)
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
        DoubleBuffered = True
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
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
    Friend WithEvents Label4 As Label
End Class
