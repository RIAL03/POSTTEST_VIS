<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Read
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
        Label2 = New Label()
        txtSearch = New TextBox()
        rbMining = New RadioButton()
        rbNether = New RadioButton()
        rbFarming = New RadioButton()
        rbFishing = New RadioButton()
        btnSearch = New Button()
        btnReset = New Button()
        Panel1 = New Panel()
        DataGridView1 = New DataGridView()
        btnReturn = New Button()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(89), CByte(212), CByte(255))
        Label2.Location = New Point(46, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(148, 32)
        Label2.TabIndex = 1
        Label2.Text = "Search Item"
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(21, 77)
        txtSearch.Multiline = True
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Item Name"
        txtSearch.Size = New Size(221, 102)
        txtSearch.TabIndex = 2
        ' 
        ' rbMining
        ' 
        rbMining.AutoSize = True
        rbMining.BackColor = Color.Transparent
        rbMining.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        rbMining.ForeColor = Color.White
        rbMining.Location = New Point(21, 240)
        rbMining.Name = "rbMining"
        rbMining.Size = New Size(102, 34)
        rbMining.TabIndex = 3
        rbMining.TabStop = True
        rbMining.Text = "Mining"
        rbMining.UseVisualStyleBackColor = False
        ' 
        ' rbNether
        ' 
        rbNether.AutoSize = True
        rbNether.BackColor = Color.Transparent
        rbNether.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        rbNether.ForeColor = Color.White
        rbNether.Location = New Point(21, 196)
        rbNether.Name = "rbNether"
        rbNether.Size = New Size(99, 34)
        rbNether.TabIndex = 4
        rbNether.TabStop = True
        rbNether.Text = "Nether"
        rbNether.UseVisualStyleBackColor = False
        ' 
        ' rbFarming
        ' 
        rbFarming.AutoSize = True
        rbFarming.BackColor = Color.Transparent
        rbFarming.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        rbFarming.ForeColor = Color.White
        rbFarming.Location = New Point(21, 283)
        rbFarming.Name = "rbFarming"
        rbFarming.Size = New Size(111, 34)
        rbFarming.TabIndex = 5
        rbFarming.TabStop = True
        rbFarming.Text = "Farming"
        rbFarming.UseVisualStyleBackColor = False
        ' 
        ' rbFishing
        ' 
        rbFishing.AutoSize = True
        rbFishing.BackColor = Color.Transparent
        rbFishing.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        rbFishing.ForeColor = Color.White
        rbFishing.Location = New Point(21, 330)
        rbFishing.Name = "rbFishing"
        rbFishing.Size = New Size(102, 34)
        rbFishing.TabIndex = 6
        rbFishing.TabStop = True
        rbFishing.Text = "Fishing"
        rbFishing.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.Location = New Point(113, 384)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(136, 39)
        btnSearch.TabIndex = 7
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReset.Location = New Point(21, 384)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(86, 39)
        btnReset.TabIndex = 8
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(11), CByte(31), CByte(53))
        Panel1.Controls.Add(btnReset)
        Panel1.Controls.Add(btnSearch)
        Panel1.Controls.Add(rbFishing)
        Panel1.Controls.Add(rbFarming)
        Panel1.Controls.Add(rbNether)
        Panel1.Controls.Add(rbMining)
        Panel1.Controls.Add(txtSearch)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(675, 156)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(265, 437)
        Panel1.TabIndex = 2
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(73, 156)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(581, 437)
        DataGridView1.TabIndex = 1
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
        btnReturn.Location = New Point(58, 61)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(123, 57)
        btnReturn.TabIndex = 11
        btnReturn.UseVisualStyleBackColor = False
        ' 
        ' Read
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.createform
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1016, 701)
        Controls.Add(btnReturn)
        Controls.Add(Panel1)
        Controls.Add(DataGridView1)
        DoubleBuffered = True
        Name = "Read"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Read"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents rbMining As RadioButton
    Friend WithEvents rbNether As RadioButton
    Friend WithEvents rbFarming As RadioButton
    Friend WithEvents rbFishing As RadioButton
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnReturn As Button
End Class
