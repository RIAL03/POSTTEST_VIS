Public Class ChooseCreate
    Private Sub btnItems_Click(sender As Object, e As EventArgs) Handles btnItems.Click
        Create.Show()
        Me.Hide()
    End Sub

    Private Sub btnCategory_Click(sender As Object, e As EventArgs) Handles btnCategory.Click
        Category.Show()
        Me.Hide()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Login.Show()
        Me.Hide()
    End Sub
End Class