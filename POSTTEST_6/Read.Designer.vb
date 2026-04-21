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
        btnSearch = New Button()
        btnReset = New Button()
        Panel1 = New Panel()
        cbCategorySearch = New ComboBox()
        DataGridView1 = New DataGridView()
        btnReturn = New Button()
        TabControl1 = New TabControl()
        Items = New TabPage()
        TabPage2 = New TabPage()
        DataGridView2 = New DataGridView()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        Items.SuspendLayout()
        TabPage2.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
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
        txtSearch.PlaceholderText = "Name"
        txtSearch.Size = New Size(221, 102)
        txtSearch.TabIndex = 2
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
        Panel1.Controls.Add(cbCategorySearch)
        Panel1.Controls.Add(btnReset)
        Panel1.Controls.Add(btnSearch)
        Panel1.Controls.Add(txtSearch)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(675, 156)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(265, 437)
        Panel1.TabIndex = 2
        ' 
        ' cbCategorySearch
        ' 
        cbCategorySearch.AutoCompleteCustomSource.AddRange(New String() {"Nether", "Mining", "Farming", "Fishing"})
        cbCategorySearch.DropDownStyle = ComboBoxStyle.DropDownList
        cbCategorySearch.Font = New Font("Segoe Fluent Icons", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cbCategorySearch.ForeColor = Color.FromArgb(CByte(11), CByte(31), CByte(53))
        cbCategorySearch.FormattingEnabled = True
        cbCategorySearch.Location = New Point(21, 220)
        cbCategorySearch.Name = "cbCategorySearch"
        cbCategorySearch.Size = New Size(221, 29)
        cbCategorySearch.TabIndex = 9
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(5, 5)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(555, 407)
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
        ' TabControl1
        ' 
        TabControl1.Controls.Add(Items)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(81, 156)
        TabControl1.Margin = New Padding(3, 2, 3, 2)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(572, 437)
        TabControl1.TabIndex = 12
        ' 
        ' Items
        ' 
        Items.Controls.Add(DataGridView1)
        Items.Location = New Point(4, 24)
        Items.Margin = New Padding(3, 2, 3, 2)
        Items.Name = "Items"
        Items.Padding = New Padding(3, 2, 3, 2)
        Items.Size = New Size(564, 409)
        Items.TabIndex = 0
        Items.Text = "Items"
        Items.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(DataGridView2)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Margin = New Padding(3, 2, 3, 2)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3, 2, 3, 2)
        TabPage2.Size = New Size(564, 409)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Category"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.AllowUserToDeleteRows = False
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.BackgroundColor = Color.White
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(6, 6)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.ReadOnly = True
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.Size = New Size(555, 400)
        DataGridView2.TabIndex = 10
        ' 
        ' Read
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.createform
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1016, 701)
        Controls.Add(TabControl1)
        Controls.Add(btnReturn)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Name = "Read"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Read"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        Items.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnReturn As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Items As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cbCategorySearch As ComboBox
    Friend WithEvents DataGridView2 As DataGridView
End Class
