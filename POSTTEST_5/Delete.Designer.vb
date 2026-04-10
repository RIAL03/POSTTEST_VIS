<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Delete
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
        DataGridView1 = New DataGridView()
        txtDeleteID = New TextBox()
        Panel1 = New Panel()
        btnDelete = New Button()
        Label1 = New Label()
        Label2 = New Label()
        btnReturn = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(65, 117)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(486, 319)
        DataGridView1.TabIndex = 2
        ' 
        ' txtDeleteID
        ' 
        txtDeleteID.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDeleteID.Location = New Point(75, 97)
        txtDeleteID.Name = "txtDeleteID"
        txtDeleteID.PlaceholderText = "Select ID"
        txtDeleteID.Size = New Size(140, 33)
        txtDeleteID.TabIndex = 3
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(11), CByte(31), CByte(53))
        Panel1.Controls.Add(btnDelete)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtDeleteID)
        Panel1.Location = New Point(567, 129)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(237, 296)
        Panel1.TabIndex = 5
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(48, 233)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(136, 39)
        btnDelete.TabIndex = 8
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(15, 95)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 32)
        Label1.TabIndex = 7
        Label1.Text = "ID :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(89), CByte(212), CByte(255))
        Label2.Location = New Point(48, 16)
        Label2.Name = "Label2"
        Label2.Size = New Size(146, 32)
        Label2.TabIndex = 6
        Label2.Text = "Delete Item"
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
        btnReturn.Location = New Point(51, 45)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(92, 44)
        btnReturn.TabIndex = 12
        btnReturn.UseVisualStyleBackColor = False
        ' 
        ' Delete
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.createform
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(868, 516)
        Controls.Add(btnReturn)
        Controls.Add(Panel1)
        Controls.Add(DataGridView1)
        DoubleBuffered = True
        Name = "Delete"
        Text = "Delete"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtDeleteID As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnReturn As Button
End Class
