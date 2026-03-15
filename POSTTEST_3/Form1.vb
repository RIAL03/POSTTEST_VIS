Imports System.IO

Public Class Form1
    Dim grupHobi() As CheckBox
    Dim grupJK() As RadioButton

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = " "
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd MMMM yyyy"
    End Sub

    ' 2. Fungsi Cek Semua Data (Memanggil ValidationModule)
    Private Function CekData() As Boolean
        grupHobi = {CheckBox1, CheckBox2, CheckBox3, CheckBox4, CheckBox5, CheckBox6, CheckBox7, CheckBox8, CheckBox9, CheckBox10}
        grupJK = {RadioButton1, RadioButton2}

        If Not ValidasiTextBox(TextBox1, "Nama tidak boleh kosong!") Then Return False
        If Not ValidasiTextBox(TextBox2, "Umur tidak boleh kosong!") Then Return False
        If Not ValidasiTextBox(TextBox3, "No HP tidak boleh kosong!") Then Return False
        If Not ValidasiTanggal(DateTimePicker1, "Pilih Tanggal Lahir!") Then Return False
        If Not ValidasiTextBox(TextBox4, "Alamat tidak boleh kosong!") Then Return False
        If Not ValidasiRadioButton(grupJK, "Pilih Jenis Kelamin Anda!") Then Return False
        If Not ValidasiCheckBox(grupHobi, "Pilih minimal 1 Hoby!") Then Return False
        If Not ValidasiPictureBox(PictureBox1, "Foto Profile belum dimasukkan!") Then Return False

        Return True
    End Function

    ' 3. Tombol Cetak Kartu
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CekData() Then
            grupHobi = {CheckBox1, CheckBox2, CheckBox3, CheckBox4, CheckBox5, CheckBox6, CheckBox7, CheckBox8, CheckBox9, CheckBox10}
            grupJK = {RadioButton1, RadioButton2}

            ' Masukkan ke Gudang (DataModule)
            DataModule.Nama = TextBox1.Text
            DataModule.Umur = TextBox2.Text
            DataModule.NoHp = TextBox3.Text
            DataModule.TglLahir = DateTimePicker1.Value.ToString("dd MMMM yyyy")
            DataModule.Alamat = TextBox4.Text
            DataModule.JK = GetSelectedRadioButton(grupJK)
            DataModule.Hobi = GetSelectedCheckBox(grupHobi)

            ' Panggil Form 2
            Form2.Show()
        End If
    End Sub

    ' 4. Tombol Browse Foto
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        openFileDialog.Title = "Pilih Gambar Profile"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Menyimpan foto fisik ke folder "Foto" di dalam project
            Dim folderPath As String = Path.Combine(Application.StartupPath, "Foto")
            Dim fileName As String = "Profile_" & DateTime.Now.ToString("yyyyMMddHHmmss") & Path.GetExtension(openFileDialog.FileName)
            Dim destinationPath As String = Path.Combine(folderPath, fileName)

            If Not Directory.Exists(folderPath) Then
                Directory.CreateDirectory(folderPath)
            End If

            File.Copy(openFileDialog.FileName, destinationPath, True)

            ' Simpan alamat fotonya ke Gudang dan tampilkan di Form1
            DataModule.Foto = destinationPath
            PictureBox1.Image = Image.FromFile(destinationPath)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    ' 5. Batasan Ketikan (Angka / Huruf)
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        ValidationModule.HanyaHuruf(sender, e)
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress, TextBox3.KeyPress
        ValidationModule.HanyaAngka(sender, e)
    End Sub
End Class