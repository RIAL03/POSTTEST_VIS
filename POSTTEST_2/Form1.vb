Public Class Form1

    'Function mencari judul buku.
    Function CariBuku(ByVal judul As String) As Integer

        For i As Integer = 0 To jumlahBuku - 1

            'ambil judul tanpa genre
            Dim judulBuku As String = daftarBuku(i).Split("("c)(0).Trim()

            If judulBuku.ToLower = judul.ToLower Then
                Return i
            End If

        Next

        Return -1

    End Function

    'Procedure memakai ByVal
    Sub TampilkanBuku(ByVal list As ListBox)

        list.Items.Clear()

        For i As Integer = 0 To jumlahBuku - 1
            list.Items.Add(daftarBuku(i))
        Next

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Dim judul As String = txtJudulTambah.Text
        Dim genre As String = txtGenre.Text

        If judul = "" Or genre = "" Then
            MessageBox.Show("Isi semua data!")
            Exit Sub
        End If

        'format buku
        daftarBuku(jumlahBuku) = judul & " (" & genre & ")"
        jumlahBuku += 1

        'tampilkan ulang list
        TampilkanBuku(lstBuku)

        txtJudulTambah.Clear()
        txtGenre.Clear()

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        Dim judul As String = txtJudulHapus.Text

        Dim index As Integer = CariBuku(judul)

        If index = -1 Then
            MessageBox.Show("Buku tidak ditemukan")
            Exit Sub
        End If

        'geser data array
        For i As Integer = index To jumlahBuku - 2
            daftarBuku(i) = daftarBuku(i + 1)
        Next

        jumlahBuku -= 1

        TampilkanBuku(lstBuku)

        txtJudulHapus.Clear()

    End Sub

    Private Sub lstBuku_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBuku.SelectedIndexChanged

    End Sub
End Class
