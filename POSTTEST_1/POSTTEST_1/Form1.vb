Public Class Form1
    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Dim ip As Double

        ' Validasi input angka
        If Double.TryParse(txtIP.Text, ip) Then

            If ip < 0 Or ip > 4 Then
                MessageBox.Show("IP harus antara 0 sampai 4")
                Exit Sub
            End If

            ' Tambahkan ke total
            totalIP += ip
            jumlahSemester += 1

            ' Hitung IPK
            Dim ipk As Double = totalIP / jumlahSemester

            txtIPK.Text = ipk.ToString("0.00")

            ' Tentukan Predikat
            If ipk >= 2.0 And ipk <= 2.75 Then
                lblPredikat.Text = "Cukup"
            ElseIf ipk >= 2.76 And ipk <= 3.0 Then
                lblPredikat.Text = "Memuaskan"
            ElseIf ipk >= 3.01 Then
                lblPredikat.Text = "Sangat Memuaskan"
            Else
                lblPredikat.Text = "-"
            End If

            ' Kosongkan input
            txtIP.Clear()
            txtIP.Focus()

        Else
            MessageBox.Show("Masukkan angka yang valid!")
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        totalIP = 0
        jumlahSemester = 0

        txtIP.Clear()
        txtIPK.Clear()
        lblPredikat.Text = "-"

        txtIP.Focus()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
