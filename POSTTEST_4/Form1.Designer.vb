<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        DateTimePicker1 = New DateTimePicker()
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        MenuLihatKartu = New ToolStripMenuItem()
        MenuSimpanData = New ToolStripMenuItem()
        MenuBukaData = New ToolStripMenuItem()
        MenuKeluar = New ToolStripMenuItem()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        label1 = New Label()
        cmbKomunitas = New ComboBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        txtID = New TextBox()
        txtNama = New TextBox()
        TabPage2 = New TabPage()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        mskTelepon = New MaskedTextBox()
        txtEmail = New TextBox()
        txtAlamat = New TextBox()
        TabPage3 = New TabPage()
        Label9 = New Label()
        btnCetak = New Button()
        GroupBox1 = New GroupBox()
        chkTraveling = New CheckBox()
        chkMemasak = New CheckBox()
        chkMenggambar = New CheckBox()
        chkFotografi = New CheckBox()
        chkOlahraga = New CheckBox()
        chkMainGame = New CheckBox()
        chkMenulis = New CheckBox()
        chkMembaca = New CheckBox()
        GroupBox2 = New GroupBox()
        rbSekretaris = New RadioButton()
        rbAdmin = New RadioButton()
        rbAnggota = New RadioButton()
        rbKetua = New RadioButton()
        btnBrowse = New Button()
        pbFotoProfile = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        PictureBox1 = New PictureBox()
        StarkIndustries = New Label()
        MenuStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(pbFotoProfile, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(136, 108)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(253, 27)
        DateTimePicker1.TabIndex = 2
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.Transparent
        MenuStrip1.Dock = DockStyle.None
        MenuStrip1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, MenuLihatKartu, MenuSimpanData, MenuBukaData, MenuKeluar})
        MenuStrip1.Location = New Point(329, 196)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(460, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(93, 24)
        InputDataToolStripMenuItem.Text = "Input Data"
        ' 
        ' MenuLihatKartu
        ' 
        MenuLihatKartu.Name = "MenuLihatKartu"
        MenuLihatKartu.Size = New Size(95, 24)
        MenuLihatKartu.Text = "Lihat Kartu"
        ' 
        ' MenuSimpanData
        ' 
        MenuSimpanData.Name = "MenuSimpanData"
        MenuSimpanData.Size = New Size(108, 24)
        MenuSimpanData.Text = "Simpan Data"
        ' 
        ' MenuBukaData
        ' 
        MenuBukaData.Name = "MenuBukaData"
        MenuBukaData.Size = New Size(91, 24)
        MenuBukaData.Text = "Buka Data"
        ' 
        ' MenuKeluar
        ' 
        MenuKeluar.Name = "MenuKeluar"
        MenuKeluar.Size = New Size(65, 24)
        MenuKeluar.Text = "Keluar"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(344, 247)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(554, 304)
        TabControl1.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(label1)
        TabPage1.Controls.Add(cmbKomunitas)
        TabPage1.Controls.Add(rbPerempuan)
        TabPage1.Controls.Add(rbLaki)
        TabPage1.Controls.Add(DateTimePicker1)
        TabPage1.Controls.Add(txtID)
        TabPage1.Controls.Add(txtNama)
        TabPage1.ForeColor = Color.Transparent
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(546, 271)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utama"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(12, 228)
        Label5.Name = "Label5"
        Label5.Size = New Size(114, 20)
        Label5.TabIndex = 10
        Label5.Text = "Jenis Komunitas"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(12, 154)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 20)
        Label4.TabIndex = 9
        Label4.Text = "Jenis Kelamin"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(12, 111)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 20)
        Label3.TabIndex = 8
        Label3.Text = "Tanggal Lahir"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(12, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 7
        Label2.Text = "ID Anggota"
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.BackColor = Color.Transparent
        label1.ForeColor = Color.Black
        label1.Location = New Point(12, 25)
        label1.Name = "label1"
        label1.Size = New Size(49, 20)
        label1.TabIndex = 6
        label1.Text = "Nama"
        ' 
        ' cmbKomunitas
        ' 
        cmbKomunitas.DropDownStyle = ComboBoxStyle.DropDownList
        cmbKomunitas.FormattingEnabled = True
        cmbKomunitas.Items.AddRange(New Object() {"Tech Innovators", "Creative Minds", "Digital Warriors", "Code Masters", "Pixel Studio", "Visionary Team", "NextGen Creators", "Alpha Community", "Infinity Squad", "Nova Club"})
        cmbKomunitas.Location = New Point(136, 225)
        cmbKomunitas.Name = "cmbKomunitas"
        cmbKomunitas.Size = New Size(253, 28)
        cmbKomunitas.TabIndex = 5
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.ForeColor = Color.Black
        rbPerempuan.Location = New Point(139, 184)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(101, 24)
        rbPerempuan.TabIndex = 4
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.ForeColor = Color.Black
        rbLaki.Location = New Point(139, 154)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(82, 24)
        rbLaki.TabIndex = 3
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(136, 64)
        txtID.Name = "txtID"
        txtID.Size = New Size(390, 27)
        txtID.TabIndex = 1
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(136, 22)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(390, 27)
        txtNama.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Label8)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(mskTelepon)
        TabPage2.Controls.Add(txtEmail)
        TabPage2.Controls.Add(txtAlamat)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(546, 271)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak & info"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(13, 114)
        Label8.Name = "Label8"
        Label8.Size = New Size(57, 20)
        Label8.TabIndex = 6
        Label8.Text = "Alamat"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(13, 69)
        Label7.Name = "Label7"
        Label7.Size = New Size(46, 20)
        Label7.TabIndex = 5
        Label7.Text = "Email"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(13, 26)
        Label6.Name = "Label6"
        Label6.Size = New Size(113, 20)
        Label6.TabIndex = 4
        Label6.Text = "Nomor Telepon"
        ' 
        ' mskTelepon
        ' 
        mskTelepon.Location = New Point(145, 23)
        mskTelepon.Mask = "0000-0000-0000"
        mskTelepon.Name = "mskTelepon"
        mskTelepon.Size = New Size(154, 27)
        mskTelepon.TabIndex = 3
        mskTelepon.ValidatingType = GetType(Integer)
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(145, 66)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(380, 27)
        txtEmail.TabIndex = 1
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(145, 114)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(380, 27)
        txtAlamat.TabIndex = 0
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(Label9)
        TabPage3.Controls.Add(btnCetak)
        TabPage3.Controls.Add(GroupBox1)
        TabPage3.Controls.Add(GroupBox2)
        TabPage3.Controls.Add(btnBrowse)
        TabPage3.Controls.Add(pbFotoProfile)
        TabPage3.Location = New Point(4, 29)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(546, 271)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profile & Aktivitas"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(36, 24)
        Label9.Name = "Label9"
        Label9.Size = New Size(86, 20)
        Label9.TabIndex = 6
        Label9.Text = "Foto Profile"
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(164, 219)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(367, 31)
        btnCetak.TabIndex = 5
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(chkTraveling)
        GroupBox1.Controls.Add(chkMemasak)
        GroupBox1.Controls.Add(chkMenggambar)
        GroupBox1.Controls.Add(chkFotografi)
        GroupBox1.Controls.Add(chkOlahraga)
        GroupBox1.Controls.Add(chkMainGame)
        GroupBox1.Controls.Add(chkMenulis)
        GroupBox1.Controls.Add(chkMembaca)
        GroupBox1.Location = New Point(297, 20)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(236, 176)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' chkTraveling
        ' 
        chkTraveling.AutoSize = True
        chkTraveling.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkTraveling.Location = New Point(130, 121)
        chkTraveling.Name = "chkTraveling"
        chkTraveling.Size = New Size(79, 21)
        chkTraveling.TabIndex = 8
        chkTraveling.Text = "Traveling"
        chkTraveling.UseVisualStyleBackColor = True
        ' 
        ' chkMemasak
        ' 
        chkMemasak.AutoSize = True
        chkMemasak.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkMemasak.Location = New Point(130, 94)
        chkMemasak.Name = "chkMemasak"
        chkMemasak.Size = New Size(83, 21)
        chkMemasak.TabIndex = 7
        chkMemasak.Text = "Memasak"
        chkMemasak.UseVisualStyleBackColor = True
        ' 
        ' chkMenggambar
        ' 
        chkMenggambar.AutoSize = True
        chkMenggambar.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkMenggambar.Location = New Point(130, 67)
        chkMenggambar.Name = "chkMenggambar"
        chkMenggambar.Size = New Size(107, 21)
        chkMenggambar.TabIndex = 6
        chkMenggambar.Text = "Menggambar"
        chkMenggambar.UseVisualStyleBackColor = True
        ' 
        ' chkFotografi
        ' 
        chkFotografi.AutoSize = True
        chkFotografi.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkFotografi.Location = New Point(130, 40)
        chkFotografi.Name = "chkFotografi"
        chkFotografi.Size = New Size(80, 21)
        chkFotografi.TabIndex = 4
        chkFotografi.Text = "Fotografi"
        chkFotografi.UseVisualStyleBackColor = True
        ' 
        ' chkOlahraga
        ' 
        chkOlahraga.AutoSize = True
        chkOlahraga.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkOlahraga.Location = New Point(14, 121)
        chkOlahraga.Name = "chkOlahraga"
        chkOlahraga.Size = New Size(81, 21)
        chkOlahraga.TabIndex = 3
        chkOlahraga.Text = "Olahraga"
        chkOlahraga.UseVisualStyleBackColor = True
        ' 
        ' chkMainGame
        ' 
        chkMainGame.AutoSize = True
        chkMainGame.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkMainGame.Location = New Point(14, 94)
        chkMainGame.Name = "chkMainGame"
        chkMainGame.Size = New Size(93, 21)
        chkMainGame.TabIndex = 2
        chkMainGame.Text = "Main game"
        chkMainGame.UseVisualStyleBackColor = True
        ' 
        ' chkMenulis
        ' 
        chkMenulis.AutoSize = True
        chkMenulis.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkMenulis.Location = New Point(14, 67)
        chkMenulis.Name = "chkMenulis"
        chkMenulis.Size = New Size(72, 21)
        chkMenulis.TabIndex = 1
        chkMenulis.Text = "Menulis"
        chkMenulis.UseVisualStyleBackColor = True
        ' 
        ' chkMembaca
        ' 
        chkMembaca.AutoSize = True
        chkMembaca.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkMembaca.Location = New Point(14, 40)
        chkMembaca.Name = "chkMembaca"
        chkMembaca.Size = New Size(85, 21)
        chkMembaca.TabIndex = 0
        chkMembaca.Text = "Membaca"
        chkMembaca.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(rbSekretaris)
        GroupBox2.Controls.Add(rbAdmin)
        GroupBox2.Controls.Add(rbAnggota)
        GroupBox2.Controls.Add(rbKetua)
        GroupBox2.Location = New Point(158, 20)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(120, 176)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Peran"
        ' 
        ' rbSekretaris
        ' 
        rbSekretaris.AutoSize = True
        rbSekretaris.Location = New Point(14, 127)
        rbSekretaris.Name = "rbSekretaris"
        rbSekretaris.Size = New Size(91, 24)
        rbSekretaris.TabIndex = 3
        rbSekretaris.TabStop = True
        rbSekretaris.Text = "Sekretaris"
        rbSekretaris.UseVisualStyleBackColor = True
        ' 
        ' rbAdmin
        ' 
        rbAdmin.AutoSize = True
        rbAdmin.Location = New Point(14, 97)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.Size = New Size(71, 24)
        rbAdmin.TabIndex = 2
        rbAdmin.TabStop = True
        rbAdmin.Text = "Admin"
        rbAdmin.UseVisualStyleBackColor = True
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.Location = New Point(14, 67)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(85, 24)
        rbAnggota.TabIndex = 1
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.Location = New Point(14, 37)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(65, 24)
        rbKetua.TabIndex = 0
        rbKetua.TabStop = True
        rbKetua.Text = "Ketua"
        rbKetua.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(42, 206)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(75, 27)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' pbFotoProfile
        ' 
        pbFotoProfile.BackColor = Color.IndianRed
        pbFotoProfile.Location = New Point(23, 60)
        pbFotoProfile.Name = "pbFotoProfile"
        pbFotoProfile.Size = New Size(108, 133)
        pbFotoProfile.TabIndex = 0
        pbFotoProfile.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources._7273f4f4_d29f_43a9_8f32_cef7738c5173
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(874, 198)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(42, 43)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' StarkIndustries
        ' 
        StarkIndustries.AutoSize = True
        StarkIndustries.BackColor = Color.Transparent
        StarkIndustries.Font = New Font("Script MT Bold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        StarkIndustries.ForeColor = Color.ForestGreen
        StarkIndustries.Location = New Point(818, 207)
        StarkIndustries.Name = "StarkIndustries"
        StarkIndustries.Size = New Size(47, 23)
        StarkIndustries.TabIndex = 3
        StarkIndustries.Text = "Gaia"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Untitled_111122
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1223, 734)
        Controls.Add(StarkIndustries)
        Controls.Add(PictureBox1)
        Controls.Add(TabControl1)
        Controls.Add(MenuStrip1)
        DoubleBuffered = True
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(pbFotoProfile, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuLihatKartu As ToolStripMenuItem
    Friend WithEvents MenuSimpanData As ToolStripMenuItem
    Friend WithEvents MenuBukaData As ToolStripMenuItem
    Friend WithEvents MenuKeluar As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents cmbKomunitas As ComboBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents mskTelepon As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents pbFotoProfile As PictureBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents chkTraveling As CheckBox
    Friend WithEvents chkMemasak As CheckBox
    Friend WithEvents chkMenggambar As CheckBox
    Friend WithEvents chkFotografi As CheckBox
    Friend WithEvents chkOlahraga As CheckBox
    Friend WithEvents chkMainGame As CheckBox
    Friend WithEvents chkMenulis As CheckBox
    Friend WithEvents chkMembaca As CheckBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents rbSekretaris As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents StarkIndustries As Label

End Class
