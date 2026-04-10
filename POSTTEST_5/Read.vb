Imports System.Data
Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class Read
    Dim connString As String = "server=localhost;userid=root;password=;database=db_pw_item"
    Dim conn As New MySqlConnection(connString)

    Private Sub Read_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanData()
    End Sub

    Private Sub TampilkanData()
        Try
            conn.Open()

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

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM items WHERE 1=1"

            If txtSearch.Text.Trim() <> "" Then
                query &= " AND name LIKE @name"
            End If

            Dim selectedCategory As String = ""
            If rbNether.Checked Then
                selectedCategory = "Nether"
            ElseIf rbMining.Checked Then
                selectedCategory = "Mining"
            ElseIf rbFarming.Checked Then
                selectedCategory = "Farming"
            ElseIf rbFishing.Checked Then
                selectedCategory = "Fishing"
            End If

            If selectedCategory <> "" Then
                query &= " AND category = @category"
            End If

            Dim cmd As New MySqlCommand(query, conn)

            If txtSearch.Text.Trim() <> "" Then
                cmd.Parameters.AddWithValue("@name", "%" & txtSearch.Text.Trim() & "%")
            End If

            If selectedCategory <> "" Then
                cmd.Parameters.AddWithValue("@category", selectedCategory)
            End If

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridView1.DataSource = table

        Catch ex As Exception
            MessageBox.Show("Gagal melakukan pencarian: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        txtSearch.Clear()
        rbNether.Checked = False
        rbMining.Checked = False
        rbFarming.Checked = False
        rbFishing.Checked = False

        TampilkanData()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles rbFishing.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Login.Show()
        Close()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Login.Show()
        Me.Close()
    End Sub
End Class