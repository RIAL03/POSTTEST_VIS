<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Category
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
        btnReturn = New Button()
        btnSave = New Button()
        txtDeskripsi = New TextBox()
        txtName = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnReturn
        ' 
        btnReturn.BackColor = Color.Transparent
        btnReturn.BackgroundImage = My.Resources.Resources.backbuton
        btnReturn.BackgroundImageLayout = ImageLayout.Zoom
        btnReturn.FlatAppearance.BorderSize = 0
        btnReturn.FlatStyle = FlatStyle.Flat
        btnReturn.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btnReturn.ForeColor = Color.White
        btnReturn.Location = New Point(52, 39)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(91, 41)
        btnReturn.TabIndex = 21
        btnReturn.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(11), CByte(31), CByte(53))
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(642, 368)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(144, 41)
        btnSave.TabIndex = 20
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' txtDeskripsi
        ' 
        txtDeskripsi.BackColor = Color.White
        txtDeskripsi.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtDeskripsi.ForeColor = Color.FromArgb(CByte(11), CByte(31), CByte(53))
        txtDeskripsi.Location = New Point(298, 219)
        txtDeskripsi.Multiline = True
        txtDeskripsi.Name = "txtDeskripsi"
        txtDeskripsi.PlaceholderText = "Deskripsi"
        txtDeskripsi.Size = New Size(491, 125)
        txtDeskripsi.TabIndex = 18
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.White
        txtName.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtName.ForeColor = Color.FromArgb(CByte(11), CByte(31), CByte(53))
        txtName.Location = New Point(298, 112)
        txtName.Name = "txtName"
        txtName.PlaceholderText = "Name Category"
        txtName.Size = New Size(491, 54)
        txtName.TabIndex = 17
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(251, 208)
        Label5.Name = "Label5"
        Label5.Size = New Size(26, 40)
        Label5.TabIndex = 15
        Label5.Text = ":"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(251, 118)
        Label6.Name = "Label6"
        Label6.Size = New Size(26, 40)
        Label6.TabIndex = 14
        Label6.Text = ":"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(81, 208)
        Label3.Name = "Label3"
        Label3.Size = New Size(141, 40)
        Label3.TabIndex = 13
        Label3.Text = "Quantity"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(81, 118)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 40)
        Label1.TabIndex = 11
        Label1.Text = "Name"
        ' 
        ' Category
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.createform
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(868, 479)
        Controls.Add(btnReturn)
        Controls.Add(btnSave)
        Controls.Add(txtDeskripsi)
        Controls.Add(txtName)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Label1)
        DoubleBuffered = True
        Margin = New Padding(3, 2, 3, 2)
        Name = "Category"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Category"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnReturn As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtDeskripsi As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
End Class
