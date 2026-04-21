Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class Category

    Dim connString As String = "server=localhost;userid=root;password=;database=db_pw_item"
    Dim conn As New MySqlConnection(connString)

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtName.Text.Trim() = "" Then
            MessageBox.Show("Nama Kategori wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            conn.Open()

            Dim query As String = "INSERT INTO categories (name, description) VALUES (@name, @description)"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@name", txtName.Text.Trim())
            cmd.Parameters.AddWithValue("@description", txtDeskripsi.Text.Trim())

            cmd.ExecuteNonQuery()
            MessageBox.Show("Kategori berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txtName.Clear()
            txtDeskripsi.Clear()

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        ChooseCreate.Show()
        Me.Close()
    End Sub

End Class