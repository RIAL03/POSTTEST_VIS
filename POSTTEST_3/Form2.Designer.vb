<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Gill Sans Ultra Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(536, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(358, 33)
        Label1.TabIndex = 0
        Label1.Text = "STARTORCH ACADEMY"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Tahoma", 13.8F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label2.Location = New Point(384, 131)
        Label2.Name = "Label2"
        Label2.Size = New Size(142, 299)
        Label2.TabIndex = 1
        Label2.Text = "Nama" & vbCrLf & vbCrLf & "Umur" & vbCrLf & vbCrLf & "Tanggal Lahir" & vbCrLf & vbCrLf & "Jenis Kelamin" & vbCrLf & vbCrLf & "No Hp" & vbCrLf & vbCrLf & "Alamat" & vbCrLf & vbCrLf & "Hoby" & vbCrLf
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Tahoma", 13.8F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label3.Location = New Point(565, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(17, 299)
        Label3.TabIndex = 2
        Label3.Text = ":" & vbCrLf & vbCrLf & ":" & vbCrLf & vbCrLf & ":" & vbCrLf & vbCrLf & ":" & vbCrLf & vbCrLf & ":" & vbCrLf & vbCrLf & ":" & vbCrLf & vbCrLf & ":" & vbCrLf
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(25, 65)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(314, 410)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = SystemColors.Control
        BackgroundImage = My.Resources.Resources.Gemini_Generated_Image_rovkharovkharovk__2_
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(976, 505)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
