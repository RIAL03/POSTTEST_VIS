Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class Create

    Dim connString As String = "server=localhost;userid=root;password=;database=db_pw_item"
    Dim conn As New MySqlConnection(connString)

    Private Sub Create_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            Dim query As String = "SELECT id, name FROM categories"
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)

            cbCategory.DataSource = table
            cbCategory.DisplayMember = "name"
            cbCategory.ValueMember = "id"
            cbCategory.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan memuat kategori: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtName.Text.Trim() = "" Or cbCategory.SelectedIndex = -1 Or txtQuantity.Text.Trim() = "" Then
            MessageBox.Show("Semua kolom (Name, Category, Quantity) harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not IsNumeric(txtQuantity.Text.Trim()) Then
            MessageBox.Show("Kolom Quantity hanya boleh diisi dengan angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            conn.Open()
            Dim query As String = "INSERT INTO items (name, category_id, quantity) VALUES (@name, @category_id, @quantity)"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@name", txtName.Text)
            cmd.Parameters.AddWithValue("@category_id", cbCategory.SelectedValue)
            cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txtName.Clear()
            cbCategory.SelectedIndex = -1
            txtQuantity.Clear()

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Login.Show()
        Me.Close()
    End Sub

End Class