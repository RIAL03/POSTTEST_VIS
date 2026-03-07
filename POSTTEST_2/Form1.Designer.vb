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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        GroupBox1 = New GroupBox()
        btnTambah = New Button()
        txtGenre = New TextBox()
        Label2 = New Label()
        txtJudulTambah = New TextBox()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        btnHapus = New Button()
        txtJudulHapus = New TextBox()
        Label4 = New Label()
        lstBuku = New ListBox()
        Panel1 = New Panel()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(btnTambah)
        GroupBox1.Controls.Add(txtGenre)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtJudulTambah)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Verdana", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = SystemColors.ButtonHighlight
        GroupBox1.Location = New Point(12, 62)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(373, 215)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Tambah Buku"
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.LimeGreen
        btnTambah.Font = New Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTambah.ForeColor = Color.White
        btnTambah.Location = New Point(238, 156)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(119, 39)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' txtGenre
        ' 
        txtGenre.BackColor = Color.White
        txtGenre.BorderStyle = BorderStyle.FixedSingle
        txtGenre.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtGenre.ForeColor = Color.Firebrick
        txtGenre.Location = New Point(159, 101)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(198, 32)
        txtGenre.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(16, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 25)
        Label2.TabIndex = 1
        Label2.Text = "Genre"
        ' 
        ' txtJudulTambah
        ' 
        txtJudulTambah.BackColor = Color.White
        txtJudulTambah.BorderStyle = BorderStyle.FixedSingle
        txtJudulTambah.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtJudulTambah.ForeColor = Color.Firebrick
        txtJudulTambah.Location = New Point(159, 49)
        txtJudulTambah.Name = "txtJudulTambah"
        txtJudulTambah.Size = New Size(198, 32)
        txtJudulTambah.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(16, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(135, 25)
        Label1.TabIndex = 0
        Label1.Text = "Judul Buku"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(btnHapus)
        GroupBox2.Controls.Add(txtJudulHapus)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Font = New Font("Verdana", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = SystemColors.ButtonHighlight
        GroupBox2.Location = New Point(405, 62)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(373, 215)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hapus Buku"
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.Red
        btnHapus.Font = New Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(240, 156)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(119, 39)
        btnHapus.TabIndex = 5
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' txtJudulHapus
        ' 
        txtJudulHapus.BackColor = Color.White
        txtJudulHapus.BorderStyle = BorderStyle.FixedSingle
        txtJudulHapus.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtJudulHapus.ForeColor = Color.Firebrick
        txtJudulHapus.Location = New Point(161, 49)
        txtJudulHapus.Name = "txtJudulHapus"
        txtJudulHapus.Size = New Size(198, 32)
        txtJudulHapus.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(16, 51)
        Label4.Name = "Label4"
        Label4.Size = New Size(135, 25)
        Label4.TabIndex = 0
        Label4.Text = "Judul Buku"
        ' 
        ' lstBuku
        ' 
        lstBuku.BackColor = Color.MintCream
        lstBuku.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lstBuku.ForeColor = Color.Black
        lstBuku.FormattingEnabled = True
        lstBuku.Location = New Point(12, 305)
        lstBuku.Name = "lstBuku"
        lstBuku.Size = New Size(744, 164)
        lstBuku.TabIndex = 5
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Location = New Point(12, 305)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(766, 186)
        Panel1.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(791, 503)
        Controls.Add(lstBuku)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        ForeColor = SystemColors.ControlLightLight
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtJudulTambah As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtJudulHapus As TextBox
    Friend WithEvents lstBuku As ListBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents Panel1 As Panel

End Class
