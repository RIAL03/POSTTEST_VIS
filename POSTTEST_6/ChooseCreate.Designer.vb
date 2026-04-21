<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseCreate
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
        btnItems = New Button()
        btnCategory = New Button()
        btnReturn = New Button()
        SuspendLayout()
        ' 
        ' btnItems
        ' 
        btnItems.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btnItems.Location = New Point(144, 240)
        btnItems.Margin = New Padding(3, 2, 3, 2)
        btnItems.Name = "btnItems"
        btnItems.Size = New Size(299, 55)
        btnItems.TabIndex = 0
        btnItems.Text = "Items"
        btnItems.UseVisualStyleBackColor = True
        ' 
        ' btnCategory
        ' 
        btnCategory.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btnCategory.Location = New Point(511, 240)
        btnCategory.Margin = New Padding(3, 2, 3, 2)
        btnCategory.Name = "btnCategory"
        btnCategory.Size = New Size(318, 55)
        btnCategory.TabIndex = 1
        btnCategory.Text = "Category"
        btnCategory.UseVisualStyleBackColor = True
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
        btnReturn.Location = New Point(77, 74)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(123, 57)
        btnReturn.TabIndex = 12
        btnReturn.UseVisualStyleBackColor = False
        ' 
        ' ChooseCreate
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.BackgroundPw
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(968, 499)
        Controls.Add(btnReturn)
        Controls.Add(btnCategory)
        Controls.Add(btnItems)
        DoubleBuffered = True
        Margin = New Padding(3, 2, 3, 2)
        Name = "ChooseCreate"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ChooseCreate"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnItems As Button
    Friend WithEvents btnCategory As Button
    Friend WithEvents btnReturn As Button
End Class
