Imports System.Data
Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class Update
    Dim connString As String = "server=localhost;userid=root;password=;database=db_Pw_item"
    Dim conn As New MySqlConnection(connString)

    Private Sub Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            txtUpdateID.Text = baris.Cells(0).Value.ToString()
            txtUpdateName.Text = baris.Cells(1).Value.ToString()
            txtUpdateQuantity.Text = baris.Cells(3).Value.ToString()

            Dim kategori As String = baris.Cells(2).Value.ToString()

            rbNether.Checked = False
            rbMining.Checked = False
            rbFarming.Checked = False
            rbFishing.Checked = False

            If kategori = "Nether" Then rbNether.Checked = True
            If kategori = "Mining" Then rbMining.Checked = True
            If kategori = "Farming" Then rbFarming.Checked = True
            If kategori = "Fishing" Then rbFishing.Checked = True
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If txtUpdateID.Text.Trim() = "" Or txtUpdateName.Text.Trim() = "" Or txtUpdateQuantity.Text.Trim() = "" Then
            MessageBox.Show("Semua kolom (ID, Name, Quantity) harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not IsNumeric(txtUpdateQuantity.Text) Then
            MessageBox.Show("Kolom Quantity harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not (rbNether.Checked Or rbMining.Checked Or rbFarming.Checked Or rbFishing.Checked) Then
            MessageBox.Show("Pilih salah satu kategori!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim selectedCategory As String = ""
        If rbNether.Checked Then selectedCategory = "Nether"
        If rbMining.Checked Then selectedCategory = "Mining"
        If rbFarming.Checked Then selectedCategory = "Farming"
        If rbFishing.Checked Then selectedCategory = "Fishing"

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim query As String = "UPDATE items SET name = @name, category = @category, quantity = @quantity WHERE id = @id"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@name", txtUpdateName.Text)
            cmd.Parameters.AddWithValue("@category", selectedCategory)
            cmd.Parameters.AddWithValue("@quantity", txtUpdateQuantity.Text)
            cmd.Parameters.AddWithValue("@id", txtUpdateID.Text)

            Dim barisTerpengaruh As Integer = cmd.ExecuteNonQuery()

            If barisTerpengaruh > 0 Then
                MessageBox.Show("Data berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilkanData()
                btnReset.PerformClick()
            Else
                MessageBox.Show("Update Gagal! ID tidak ditemukan di dalam database.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtUpdateID.Clear()
        txtUpdateName.Clear()
        txtUpdateQuantity.Clear()

        rbNether.Checked = False
        rbMining.Checked = False
        rbFarming.Checked = False
        rbFishing.Checked = False
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Login.Show()
        Me.Close()
    End Sub
End Class