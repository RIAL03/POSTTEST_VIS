Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Menyusun teks untuk ditempel ke Label3 
        ' Urutan menyesuaikan gambar Form 2 Anda: Nama, Umur, Tanggal Lahir, Jenis Kelamin, No Hp, Alamat, Hoby
        Dim hasilTeks As String =
            ":  " & DataModule.Nama & vbCrLf & vbCrLf &
            ":  " & DataModule.Umur & vbCrLf & vbCrLf &
            ":  " & DataModule.TglLahir & vbCrLf & vbCrLf &
            ":  " & DataModule.JK & vbCrLf & vbCrLf &
            ":  " & DataModule.NoHp & vbCrLf & vbCrLf &
            ":  " & DataModule.Alamat & vbCrLf & vbCrLf &
            ":  " & DataModule.Hobi

        Label3.Text = hasilTeks

        ' Menampilkan foto profile dari alamat yang tersimpan
        If Not String.IsNullOrEmpty(DataModule.Foto) AndAlso System.IO.File.Exists(DataModule.Foto) Then
            PictureBox1.Image = Image.FromFile(DataModule.Foto)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub
End Class