Public Class kartuKomunitas

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click

        Form1.Show()

        Me.Close()
    End Sub

    Private Sub kartuKomunitas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub

End Class