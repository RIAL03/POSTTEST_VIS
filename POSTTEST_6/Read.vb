Imports System.Data
Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class Read
    Dim connString As String = "server=localhost;userid=root;password=;database=db_pw_item"
    Dim conn As New MySqlConnection(connString)

    Private Sub Read_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
        TampilkanData()
        TampilkanDataKategori()
    End Sub

    Private Sub LoadCategories()
        Try
            conn.Open()
            Dim query As String = "SELECT id, name FROM categories"
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)

            cbCategorySearch.DataSource = table
            cbCategorySearch.DisplayMember = "name"
            cbCategorySearch.ValueMember = "id"
            cbCategorySearch.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Gagal memuat daftar kategori: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub TampilkanData()
        Try
            conn.Open()
            Dim query As String = "SELECT items.id, items.name, categories.name AS category_name, items.quantity FROM items JOIN categories ON items.category_id = categories.id"
            Dim cmd As New MySqlCommand(query, conn)

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridView1.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data items: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub TampilkanDataKategori()
        Try
            conn.Open()
            Dim query As String = "SELECT id, name, description FROM categories"
            Dim cmd As New MySqlCommand(query, conn)

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridView2.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data kategori: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            conn.Open()
            Dim query As String = "SELECT items.id, items.name, categories.name AS category_name, items.quantity FROM items JOIN categories ON items.category_id = categories.id WHERE 1=1"

            If txtSearch.Text.Trim() <> "" Then
                query &= " AND items.name LIKE @name"
            End If

            If cbCategorySearch.SelectedIndex <> -1 Then
                query &= " AND items.category_id = @category_id"
            End If

            Dim cmd As New MySqlCommand(query, conn)

            If txtSearch.Text.Trim() <> "" Then
                cmd.Parameters.AddWithValue("@name", "%" & txtSearch.Text.Trim() & "%")
            End If

            If cbCategorySearch.SelectedIndex <> -1 Then
                cmd.Parameters.AddWithValue("@category_id", cbCategorySearch.SelectedValue)
            End If

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridView1.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Gagal melakukan pencarian: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtSearch.Clear()
        cbCategorySearch.SelectedIndex = -1
        TampilkanData()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Login.Show()
        Me.Close()
    End Sub

End Class