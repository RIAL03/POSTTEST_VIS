Public Class Login
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        ChooseCreate.Show()
        Me.Hide()
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Read.Show()
        Me.Hide()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        My.Forms.Update.Show()
        Me.Hide()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Delete.Show()
        Me.Hide()
    End Sub
End Class
