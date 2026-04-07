Public Class Form1

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not e.KeyChar = " "c AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Function CekInputKosong() As Boolean
        If txtNama.Text.Trim() = "" OrElse
           txtID.Text.Trim() = "" OrElse
           cmbKomunitas.Text.Trim() = "" OrElse
           txtEmail.Text.Trim() = "" OrElse
           txtAlamat.Text.Trim() = "" Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        End If

        If Not mskTelepon.MaskFull Then
            MessageBox.Show("Nomor telepon belum lengkap! Silakan isi semua digitnya.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        End If

        If Not rbLaki.Checked AndAlso Not rbPerempuan.Checked Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        End If

        If Not rbKetua.Checked AndAlso Not rbAnggota.Checked AndAlso Not rbAdmin.Checked AndAlso Not rbSekretaris.Checked Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        End If

        If GetHobby() = "" Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        End If

        If pbFotoProfile.Image Is Nothing Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        End If

        Return False
    End Function

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        OpenFileDialog1.Title = "Pilih Foto Profil"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            pbFotoProfile.Image = Image.FromFile(OpenFileDialog1.FileName)
            pbFotoProfile.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Function GetHobby() As String
        Dim hobi As String = ""
        If chkMembaca.Checked Then hobi &= "Membaca, "
        If chkMenulis.Checked Then hobi &= "Menulis, "
        If chkMainGame.Checked Then hobi &= "Main game, "
        If chkOlahraga.Checked Then hobi &= "Olahraga, "
        If chkFotografi.Checked Then hobi &= "Fotografi, "
        If chkMenggambar.Checked Then hobi &= "Menggambar, "
        If chkMemasak.Checked Then hobi &= "Memasak, "
        If chkTraveling.Checked Then hobi &= "Traveling, "

        If hobi.EndsWith(", ") Then
            hobi = hobi.Substring(0, hobi.Length - 2)
        End If

        Return hobi
    End Function

    Private Sub TampilkanKartu()
        Dim formKartu As New kartuKomunitas()

        formKartu.lblNama.Text = txtNama.Text
        formKartu.lblID.Text = txtID.Text
        formKartu.lblKomunitas.Text = cmbKomunitas.Text
        formKartu.lblKontak.Text = mskTelepon.Text
        formKartu.lblHobby.Text = GetHobby()

        If pbFotoProfile.Image IsNot Nothing Then
            formKartu.pbFotoKartu.Image = pbFotoProfile.Image
            formKartu.pbFotoKartu.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        formKartu.Show()
        Me.Hide()
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If CekInputKosong() = True Then Exit Sub

        Dim konfirmasi As DialogResult = MessageBox.Show("Apakah Anda yakin data sudah benar dan ingin mencetak kartu?",
                                                         "Konfirmasi Cetak",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            MessageBox.Show("Kartu berhasil dicetak!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub MenuLihatKartu_Click(sender As Object, e As EventArgs) Handles MenuLihatKartu.Click
        If CekInputKosong() = True Then Exit Sub
        TampilkanKartu()
    End Sub

    Private Sub MenuSimpanData_Click(sender As Object, e As EventArgs) Handles MenuSimpanData.Click
        If CekInputKosong() = True Then Exit Sub

        Dim konfirmasi As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menyimpan data ini ke dalam file?",
                                                         "Konfirmasi Simpan Data",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "Text File (*.txt)|*.txt|CSV File (*.csv)|*.csv"
            saveFileDialog1.Title = "Simpan Data Komunitas"
            saveFileDialog1.FileName = "Data_" & txtNama.Text

            If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                Try
                    Dim jenisKelamin As String = ""
                    If rbLaki.Checked Then jenisKelamin = "Laki-laki"
                    If rbPerempuan.Checked Then jenisKelamin = "Perempuan"

                    Dim peran As String = ""
                    If rbKetua.Checked Then peran = "Ketua"
                    If rbAnggota.Checked Then peran = "Anggota"
                    If rbAdmin.Checked Then peran = "Admin"
                    If rbSekretaris.Checked Then peran = "Sekretaris"

                    Dim isiData As String = "=== DATA ANGGOTA KOMUNITAS ===" & vbCrLf &
                                            "Nama          : " & txtNama.Text & vbCrLf &
                                            "ID Anggota    : " & txtID.Text & vbCrLf &
                                            "Jenis Kelamin : " & jenisKelamin & vbCrLf &
                                            "Komunitas     : " & cmbKomunitas.Text & vbCrLf &
                                            "Nomor Telepon : " & mskTelepon.Text & vbCrLf &
                                            "Email         : " & txtEmail.Text & vbCrLf &
                                            "Alamat        : " & txtAlamat.Text & vbCrLf &
                                            "Peran         : " & peran & vbCrLf &
                                            "Hobby         : " & GetHobby()

                    System.IO.File.WriteAllText(saveFileDialog1.FileName, isiData)

                    MessageBox.Show("Data berhasil disimpan di: " & vbCrLf & saveFileDialog1.FileName,
                                    "Simpan Berhasil",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information)

                Catch ex As Exception
                    MessageBox.Show("Terjadi kesalahan saat menyimpan data: " & ex.Message,
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub MenuBukaData_Click(sender As Object, e As EventArgs) Handles MenuBukaData.Click
        Dim openFileDialogData As New OpenFileDialog()
        openFileDialogData.Filter = "Text File (*.txt)|*.txt|CSV File (*.csv)|*.csv|All Files (*.*)|*.*"
        openFileDialogData.Title = "Buka File Data Komunitas"

        If openFileDialogData.ShowDialog() = DialogResult.OK Then
            Try
                Dim isiFile As String = System.IO.File.ReadAllText(openFileDialogData.FileName)
                MessageBox.Show("Berikut adalah isi data yang Anda buka:" & vbCrLf & vbCrLf & isiFile,
                                "Data Komunitas - " & openFileDialogData.SafeFileName,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan saat membuka data: " & ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub MenuKeluar_Click(sender As Object, e As EventArgs) Handles MenuKeluar.Click
        Dim konfirmasi As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?",
                                                         "Konfirmasi Keluar",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class