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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        LabelTitle = New Label()
        LabelID = New Label()
        LabelNama = New Label()
        LabelHarga = New Label()
        txtIDLayanan = New TextBox()
        txtNamaLayanan = New TextBox()
        txtHargaDasar = New TextBox()
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
        LabelID.Location = New Point(28, 88)
        LabelID.Name = "LabelID"
        LabelID.Size = New Size(189, 23)
        LabelID.TabIndex = 1
        LabelID.Text = "ID Layanan"
        ' 
        ' LabelNama
        ' 
        LabelNama.BackColor = Color.Transparent
        LabelNama.Font = New Font("Cooper Black", 8F)
        LabelNama.Location = New Point(28, 125)
        LabelNama.Name = "LabelNama"
        LabelNama.Size = New Size(213, 23)
        LabelNama.TabIndex = 3
        LabelNama.Text = "Nama Layanan"
        ' 
        ' LabelHarga
        ' 
        LabelHarga.BackColor = Color.Transparent
        LabelHarga.Font = New Font("Cooper Black", 8F)
        LabelHarga.Location = New Point(28, 166)
        LabelHarga.Name = "LabelHarga"
        LabelHarga.Size = New Size(189, 34)
        LabelHarga.TabIndex = 5
        LabelHarga.Text = "Harga Default"
        ' 
        ' txtIDLayanan
        ' 
        txtIDLayanan.BackColor = Color.MintCream
        txtIDLayanan.Font = New Font("Cooper Black", 8F)
        txtIDLayanan.Location = New Point(358, 85)
        txtIDLayanan.Name = "txtIDLayanan"
        txtIDLayanan.Size = New Size(200, 26)
        txtIDLayanan.TabIndex = 2
        ' 
        ' txtNamaLayanan
        ' 
        txtNamaLayanan.BackColor = Color.MintCream
        txtNamaLayanan.Font = New Font("Cooper Black", 8F)
        txtNamaLayanan.Location = New Point(358, 122)
        txtNamaLayanan.Name = "txtNamaLayanan"
        txtNamaLayanan.Size = New Size(200, 26)
        txtNamaLayanan.TabIndex = 4
        ' 
        ' txtHargaDasar
        ' 
        txtHargaDasar.BackColor = Color.MintCream
        txtHargaDasar.Font = New Font("Cooper Black", 8F)
        txtHargaDasar.Location = New Point(358, 163)
        txtHargaDasar.Name = "txtHargaDasar"
        txtHargaDasar.Size = New Size(200, 26)
        txtHargaDasar.TabIndex = 6
        ' 
        ' dgvMasterLayanan
        ' 
        dgvMasterLayanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMasterLayanan.Location = New Point(588, 45)
        dgvMasterLayanan.Name = "dgvMasterLayanan"
        dgvMasterLayanan.RowHeadersWidth = 62
        dgvMasterLayanan.Size = New Size(303, 205)
        dgvMasterLayanan.TabIndex = 11
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.DarkGoldenrod
        btnSimpan.Font = New Font("Cooper Black", 8F)
        btnSimpan.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnSimpan.Location = New Point(437, 429)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(121, 53)
        btnSimpan.TabIndex = 7
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.DarkGoldenrod
        btnUbah.Font = New Font("Cooper Black", 8F)
        btnUbah.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnUbah.Location = New Point(28, 429)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(121, 53)
        btnUbah.TabIndex = 8
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.DarkGoldenrod
        btnHapus.Font = New Font("Cooper Black", 8F)
        btnHapus.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnHapus.Location = New Point(588, 429)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(121, 53)
        btnHapus.TabIndex = 9
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.DarkGoldenrod
        btnBatal.Font = New Font("Cooper Black", 8F)
        btnBatal.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnBatal.Location = New Point(740, 429)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(121, 53)
        btnBatal.TabIndex = 10
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
    Friend WithEvents txtIDLayanan As TextBox
    Friend WithEvents txtNamaLayanan As TextBox
    Friend WithEvents txtHargaDasar As TextBox
    Friend WithEvents dgvMasterLayanan As DataGridView
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class