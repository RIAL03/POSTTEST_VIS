Imports System.Data
Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class Delete

    Dim connString As String = "server=localhost;userid=root;password=;database=db_Pw_item;Allow User Variables=True"
    Dim conn As New MySqlConnection(connString)

    Private Sub Delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanData()
    End Sub

    Private Sub TampilkanData()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim query As String = "SELECT * FROM items"
            Dim cmd As New MySqlCommand(query, conn)

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridView1.DataSource = table

        Catch ex As Exception
            MessageBox.Show("Gagal memuat data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        If e.RowIndex >= 0 Then
            Dim baris As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            txtDeleteID.Text = baris.Cells(0).Value.ToString()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If txtDeleteID.Text.Trim() = "" Then
            MessageBox.Show("Silakan isi atau pilih ID yang ingin dihapus terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        Dim konfirmasi As DialogResult = MessageBox.Show("Apakah kamu yakin ingin menghapus item dengan ID " & txtDeleteID.Text & "?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()

                Dim queryHapus As String = "DELETE FROM items WHERE id = @id"
                Dim cmdHapus As New MySqlCommand(queryHapus, conn)
                cmdHapus.Parameters.AddWithValue("@id", txtDeleteID.Text)

                Dim barisTerpengaruh As Integer = cmdHapus.ExecuteNonQuery()

                If barisTerpengaruh > 0 Then

                    Dim cmdReset1 As New MySqlCommand("SET @count = 0;", conn)
                    cmdReset1.ExecuteNonQuery()

                    Dim cmdReset2 As New MySqlCommand("UPDATE items SET id = @count:= @count + 1;", conn)
                    cmdReset2.ExecuteNonQuery()

                    Dim cmdReset3 As New MySqlCommand("ALTER TABLE items AUTO_INCREMENT = 1;", conn)
                    cmdReset3.ExecuteNonQuery()

                    MessageBox.Show("Data berhasil dihapus dan ID telah disusun ulang!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    txtDeleteID.Clear()

                    TampilkanData()
                Else
                    MessageBox.Show("ID tidak ditemukan dalam database.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        End If
    End Sub
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Login.Show()
        Me.Close()
    End Sub
End Class