<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        LabelTitle = New Label()
        LabelID = New Label()
        LabelNama = New Label()
        LabelHarga = New Label()
        LabelKesulitan1 = New Label()
        LabelKesulitan2 = New Label()
        LabelKesulitan3 = New Label()
        txtIDLayanan = New TextBox()
        txtNamaLayanan = New TextBox()
        txtHargaDasar = New TextBox()
        txtKesulitan1 = New TextBox()
        txtKesulitan2 = New TextBox()
        txtKesulitan3 = New TextBox()
        dgvMasterLayanan = New DataGridView()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        CType(dgvMasterLayanan, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LabelTitle
        ' 
        LabelTitle.BackColor = Color.Transparent
        LabelTitle.Font = New Font("Cooper Black", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelTitle.Location = New Point(28, 27)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(523, 25)
        LabelTitle.TabIndex = 0
        LabelTitle.Text = "KELOLA LAYANAN JOKI"
        ' 
        ' LabelID
        ' 
        LabelID.BackColor = Color.Transparent
        LabelID.Font = New Font("Cooper Black", 8F)
        LabelID.Location = New Point(28, 75)
        LabelID.Name = "LabelID"
        LabelID.Size = New Size(189, 23)
        LabelID.TabIndex = 1
        LabelID.Text = "ID Layanan"
        ' 
        ' LabelNama
        ' 
        LabelNama.BackColor = Color.Transparent
        LabelNama.Font = New Font("Cooper Black", 8F)
        LabelNama.Location = New Point(28, 110)
        LabelNama.Name = "LabelNama"
        LabelNama.Size = New Size(213, 23)
        LabelNama.TabIndex = 3
        LabelNama.Text = "Nama Layanan"
        ' 
        ' LabelHarga
        ' 
        LabelHarga.BackColor = Color.Transparent
        LabelHarga.Font = New Font("Cooper Black", 8F)
        LabelHarga.Location = New Point(28, 145)
        LabelHarga.Name = "LabelHarga"
        LabelHarga.Size = New Size(189, 23)
        LabelHarga.TabIndex = 5
        LabelHarga.Text = "Harga Default"
        ' 
        ' LabelKesulitan1
        ' 
        LabelKesulitan1.BackColor = Color.Transparent
        LabelKesulitan1.Font = New Font("Cooper Black", 8F)
        LabelKesulitan1.Location = New Point(28, 180)
        LabelKesulitan1.Name = "LabelKesulitan1"
        LabelKesulitan1.Size = New Size(320, 23)
        LabelKesulitan1.TabIndex = 7
        LabelKesulitan1.Text = "Nama Tingkat Kesulitan 1"
        ' 
        ' LabelKesulitan2
        ' 
        LabelKesulitan2.BackColor = Color.Transparent
        LabelKesulitan2.Font = New Font("Cooper Black", 8F)
        LabelKesulitan2.Location = New Point(28, 215)
        LabelKesulitan2.Name = "LabelKesulitan2"
        LabelKesulitan2.Size = New Size(320, 23)
        LabelKesulitan2.TabIndex = 9
        LabelKesulitan2.Text = "Nama Tingkat Kesulitan 2"
        ' 
        ' LabelKesulitan3
        ' 
        LabelKesulitan3.BackColor = Color.Transparent
        LabelKesulitan3.Font = New Font("Cooper Black", 8F)
        LabelKesulitan3.Location = New Point(28, 250)
        LabelKesulitan3.Name = "LabelKesulitan3"
        LabelKesulitan3.Size = New Size(320, 23)
        LabelKesulitan3.TabIndex = 11
        LabelKesulitan3.Text = "Nama Tingkat Kesulitan 3"
        ' 
        ' txtIDLayanan
        ' 
        txtIDLayanan.BackColor = Color.MintCream
        txtIDLayanan.Font = New Font("Cooper Black", 8F)
        txtIDLayanan.Location = New Point(358, 72)
        txtIDLayanan.Name = "txtIDLayanan"
        txtIDLayanan.Size = New Size(200, 20)
        txtIDLayanan.TabIndex = 2
        ' 
        ' txtNamaLayanan
        ' 
        txtNamaLayanan.BackColor = Color.MintCream
        txtNamaLayanan.Font = New Font("Cooper Black", 8F)
        txtNamaLayanan.Location = New Point(358, 107)
        txtNamaLayanan.Name = "txtNamaLayanan"
        txtNamaLayanan.Size = New Size(200, 20)
        txtNamaLayanan.TabIndex = 4
        ' 
        ' txtHargaDasar
        ' 
        txtHargaDasar.BackColor = Color.MintCream
        txtHargaDasar.Font = New Font("Cooper Black", 8F)
        txtHargaDasar.Location = New Point(358, 142)
        txtHargaDasar.Name = "txtHargaDasar"
        txtHargaDasar.Size = New Size(200, 20)
        txtHargaDasar.TabIndex = 6
        ' 
        ' txtKesulitan1
        ' 
        txtKesulitan1.BackColor = Color.MintCream
        txtKesulitan1.Font = New Font("Cooper Black", 8F)
        txtKesulitan1.Location = New Point(358, 177)
        txtKesulitan1.Name = "txtKesulitan1"
        txtKesulitan1.Size = New Size(200, 20)
        txtKesulitan1.TabIndex = 8
        ' 
        ' txtKesulitan2
        ' 
        txtKesulitan2.BackColor = Color.MintCream
        txtKesulitan2.Font = New Font("Cooper Black", 8F)
        txtKesulitan2.Location = New Point(358, 212)
        txtKesulitan2.Name = "txtKesulitan2"
        txtKesulitan2.Size = New Size(200, 20)
        txtKesulitan2.TabIndex = 10
        ' 
        ' txtKesulitan3
        ' 
        txtKesulitan3.BackColor = Color.MintCream
        txtKesulitan3.Font = New Font("Cooper Black", 8F)
        txtKesulitan3.Location = New Point(358, 247)
        txtKesulitan3.Name = "txtKesulitan3"
        txtKesulitan3.Size = New Size(200, 20)
        txtKesulitan3.TabIndex = 12
        ' 
        ' dgvMasterLayanan
        ' 
        dgvMasterLayanan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvMasterLayanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = Color.DarkGoldenrod
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        dgvMasterLayanan.DefaultCellStyle = DataGridViewCellStyle1
        dgvMasterLayanan.Location = New Point(588, 45)
        dgvMasterLayanan.Name = "dgvMasterLayanan"
        dgvMasterLayanan.ReadOnly = True
        dgvMasterLayanan.RowHeadersWidth = 62
        dgvMasterLayanan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMasterLayanan.Size = New Size(303, 340)
        dgvMasterLayanan.TabIndex = 13
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.DarkGoldenrod
        btnSimpan.Font = New Font("Cooper Black", 8.0F)
        btnSimpan.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnSimpan.Location = New Point(437, 429)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(121, 53)
        btnSimpan.TabIndex = 14
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.DarkGoldenrod
        btnUbah.Font = New Font("Cooper Black", 8.0F)
        btnUbah.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnUbah.Location = New Point(28, 429)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(121, 53)
        btnUbah.TabIndex = 15
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.DarkGoldenrod
        btnHapus.Font = New Font("Cooper Black", 8.0F)
        btnHapus.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnHapus.Location = New Point(588, 429)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(121, 53)
        btnHapus.TabIndex = 16
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.DarkGoldenrod
        btnBatal.Font = New Font("Cooper Black", 8.0F)
        btnBatal.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnBatal.Location = New Point(740, 429)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(121, 53)
        btnBatal.TabIndex = 17
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form2
        ' 
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(906, 503)
        Controls.Add(LabelTitle)
        Controls.Add(LabelID)
        Controls.Add(txtIDLayanan)
        Controls.Add(LabelNama)
        Controls.Add(txtNamaLayanan)
        Controls.Add(LabelHarga)
        Controls.Add(txtHargaDasar)
        Controls.Add(LabelKesulitan1)
        Controls.Add(txtKesulitan1)
        Controls.Add(LabelKesulitan2)
        Controls.Add(txtKesulitan2)
        Controls.Add(LabelKesulitan3)
        Controls.Add(txtKesulitan3)
        Controls.Add(btnSimpan)
        Controls.Add(btnUbah)
        Controls.Add(btnHapus)
        Controls.Add(btnBatal)
        Controls.Add(dgvMasterLayanan)
        DoubleBuffered = True
        Name = "Form2"
        StartPosition = FormStartPosition.CenterParent
        Text = "Master Data Layanan"
        CType(dgvMasterLayanan, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents LabelTitle As Label
    Friend WithEvents LabelID As Label
    Friend WithEvents LabelNama As Label
    Friend WithEvents LabelHarga As Label
    Friend WithEvents LabelKesulitan1 As Label
    Friend WithEvents LabelKesulitan2 As Label
    Friend WithEvents LabelKesulitan3 As Label
    Friend WithEvents txtIDLayanan As TextBox
    Friend WithEvents txtNamaLayanan As TextBox
    Friend WithEvents txtHargaDasar As TextBox
    Friend WithEvents txtKesulitan1 As TextBox
    Friend WithEvents txtKesulitan2 As TextBox
    Friend WithEvents txtKesulitan3 As TextBox
    Friend WithEvents dgvMasterLayanan As DataGridView
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class