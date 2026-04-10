<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        btnCreate = New Button()
        btnRead = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        SuspendLayout()
        ' 
        ' btnCreate
        ' 
        btnCreate.BackColor = Color.Transparent
        btnCreate.BackgroundImage = My.Resources.Resources.create
        btnCreate.BackgroundImageLayout = ImageLayout.Stretch
        btnCreate.Cursor = Cursors.Hand
        btnCreate.FlatAppearance.BorderSize = 0
        btnCreate.FlatStyle = FlatStyle.Flat
        btnCreate.Location = New Point(32, 555)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(219, 85)
        btnCreate.TabIndex = 0
        btnCreate.UseVisualStyleBackColor = False
        ' 
        ' btnRead
        ' 
        btnRead.BackColor = Color.Transparent
        btnRead.BackgroundImage = My.Resources.Resources.read
        btnRead.BackgroundImageLayout = ImageLayout.Stretch
        btnRead.Cursor = Cursors.Hand
        btnRead.FlatAppearance.BorderSize = 0
        btnRead.FlatStyle = FlatStyle.Flat
        btnRead.Location = New Point(316, 555)
        btnRead.Name = "btnRead"
        btnRead.Size = New Size(219, 85)
        btnRead.TabIndex = 1
        btnRead.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Transparent
        btnUpdate.BackgroundImage = My.Resources.Resources.Update
        btnUpdate.BackgroundImageLayout = ImageLayout.Stretch
        btnUpdate.Cursor = Cursors.Hand
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Location = New Point(601, 555)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(219, 85)
        btnUpdate.TabIndex = 2
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Transparent
        btnDelete.BackgroundImage = My.Resources.Resources.Delete
        btnDelete.BackgroundImageLayout = ImageLayout.Stretch
        btnDelete.Cursor = Cursors.Hand
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Location = New Point(887, 555)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(219, 85)
        btnDelete.TabIndex = 3
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.pxielworldinterface1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1143, 644)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnRead)
        Controls.Add(btnCreate)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnCreate As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button

End Class
