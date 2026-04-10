<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Create
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtName = New TextBox()
        txtQuantity = New TextBox()
        cbCategory = New ComboBox()
        btnSave = New Button()
        btnReturn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(76, 119)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 40)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(76, 209)
        Label2.Name = "Label2"
        Label2.Size = New Size(146, 40)
        Label2.TabIndex = 1
        Label2.Text = "Category"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(76, 303)
        Label3.Name = "Label3"
        Label3.Size = New Size(141, 40)
        Label3.TabIndex = 2
        Label3.Text = "Quantity"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(246, 303)
        Label4.Name = "Label4"
        Label4.Size = New Size(26, 40)
        Label4.TabIndex = 5
        Label4.Text = ":"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(246, 209)
        Label5.Name = "Label5"
        Label5.Size = New Size(26, 40)
        Label5.TabIndex = 4
        Label5.Text = ":"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(246, 119)
        Label6.Name = "Label6"
        Label6.Size = New Size(26, 40)
        Label6.TabIndex = 3
        Label6.Text = ":"
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.White
        txtName.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtName.ForeColor = Color.FromArgb(CByte(11), CByte(31), CByte(53))
        txtName.Location = New Point(293, 113)
        txtName.Name = "txtName"
        txtName.PlaceholderText = "Name Item"
        txtName.Size = New Size(491, 54)
        txtName.TabIndex = 6
        ' 
        ' txtQuantity
        ' 
        txtQuantity.BackColor = Color.White
        txtQuantity.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtQuantity.ForeColor = Color.FromArgb(CByte(11), CByte(31), CByte(53))
        txtQuantity.Location = New Point(293, 297)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.PlaceholderText = "Quantity"
        txtQuantity.Size = New Size(491, 54)
        txtQuantity.TabIndex = 7
        ' 
        ' cbCategory
        ' 
        cbCategory.AutoCompleteCustomSource.AddRange(New String() {"Nether", "Mining", "Farming", "Fishing"})
        cbCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cbCategory.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cbCategory.ForeColor = Color.FromArgb(CByte(11), CByte(31), CByte(53))
        cbCategory.FormattingEnabled = True
        cbCategory.Items.AddRange(New Object() {"Nether", "Mining", "Farming", "Fishing"})
        cbCategory.Location = New Point(293, 200)
        cbCategory.Name = "cbCategory"
        cbCategory.Size = New Size(491, 55)
        cbCategory.TabIndex = 8
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(11), CByte(31), CByte(53))
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(637, 368)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(144, 41)
        btnSave.TabIndex = 9
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
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
        btnReturn.Location = New Point(47, 40)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(91, 41)
        btnReturn.TabIndex = 10
        btnReturn.UseVisualStyleBackColor = False
        ' 
        ' Create
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.createform
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(868, 479)
        Controls.Add(btnReturn)
        Controls.Add(btnSave)
        Controls.Add(cbCategory)
        Controls.Add(txtQuantity)
        Controls.Add(txtName)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
        Name = "Create"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Create"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents cbCategory As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnReturn As Button
End Class
