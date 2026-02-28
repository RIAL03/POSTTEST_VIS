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
        txtIP = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtIPK = New TextBox()
        btnReset = New Button()
        btnTambah = New Button()
        lblPredikat = New Label()
        SuspendLayout()
        ' 
        ' txtIP
        ' 
        txtIP.BorderStyle = BorderStyle.FixedSingle
        txtIP.Font = New Font("Segoe UI", 11F)
        txtIP.Location = New Point(234, 198)
        txtIP.Name = "txtIP"
        txtIP.Size = New Size(205, 32)
        txtIP.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(296, 202)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F)
        Label2.Location = New Point(78, 201)
        Label2.Name = "Label2"
        Label2.Size = New Size(110, 25)
        Label2.TabIndex = 3
        Label2.Text = "IP Semester"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F)
        Label3.Location = New Point(78, 302)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 25)
        Label3.TabIndex = 4
        Label3.Text = "IP Kumulatif"
        ' 
        ' txtIPK
        ' 
        txtIPK.BackColor = SystemColors.ButtonFace
        txtIPK.BorderStyle = BorderStyle.FixedSingle
        txtIPK.Font = New Font("Segoe UI", 11F)
        txtIPK.ForeColor = SystemColors.ControlDarkDark
        txtIPK.HideSelection = False
        txtIPK.Location = New Point(234, 302)
        txtIPK.Name = "txtIPK"
        txtIPK.Size = New Size(205, 32)
        txtIPK.TabIndex = 5
        txtIPK.Text = "fdfdfdfdf"
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.Silver
        btnReset.Location = New Point(345, 246)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(94, 40)
        btnReset.TabIndex = 6
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.Silver
        btnTambah.Location = New Point(234, 246)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 40)
        btnTambah.TabIndex = 7
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Location = New Point(234, 356)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(68, 20)
        lblPredikat.TabIndex = 8
        lblPredikat.Text = "brp hayo"
        ' 
        ' Form1
        ' 
        AllowDrop = True
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(950, 610)
        Controls.Add(lblPredikat)
        Controls.Add(btnTambah)
        Controls.Add(btnReset)
        Controls.Add(txtIPK)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtIP)
        Name = "Form1"
        Text = "Kalkulator IP"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtIP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIPK As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents lblPredikat As Label

End Class
