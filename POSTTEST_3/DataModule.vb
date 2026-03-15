Module DataModule
    ' Variabel untuk menyimpan data sementara
    Public Nama, Umur, NoHp, Alamat, JK, Hobi, Foto As String
    Public TglLahir As String

    ' Fungsi untuk mengambil teks dari RadioButton yang dipilih
    Public Function GetSelectedRadioButton(grupRadio() As RadioButton) As String
        For Each rb As RadioButton In grupRadio
            If rb.Checked Then
                Return rb.Text
            End If
        Next
        Return ""
    End Function

    ' Fungsi untuk mengambil teks dari CheckBox yang dicentang (Dengan Auto-Enter)
    Public Function GetSelectedCheckBox(grupCheck() As CheckBox) As String
        Dim selectedItems As New List(Of String)
        For Each cb As CheckBox In grupCheck
            If cb.Checked Then
                selectedItems.Add(cb.Text)
            End If
        Next

        ' Membuat Enter otomatis setiap 3 item
        Dim hasil As String = ""
        For i As Integer = 0 To selectedItems.Count - 1
            hasil &= selectedItems(i)

            ' Jika ini bukan hobi yang terakhir, tambahkan koma
            If i < selectedItems.Count - 1 Then
                ' Jika urutan saat ini adalah kelipatan 3 (hobi ke-3, ke-6, dst)
                If (i + 1) Mod 3 = 0 Then
                    ' Beri koma, lalu Enter (vbCrLf), dan beri 3 Spasi agar sejajar
                    hasil &= "," & vbCrLf & "   "
                Else
                    ' Jika belum 3, cukup beri koma dan spasi biasa
                    hasil &= ", "
                End If
            End If
        Next

        Return hasil
    End Function
End Module