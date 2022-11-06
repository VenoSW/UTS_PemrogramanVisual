Public Class Form1

    Private Sub BtnTampilkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTampilkan.Click
        Dim JK As String
        Dim Buku As String

        If RBLaki.Checked = True Then
            JK = RBLaki.Text
        Else
            JK = RBPerempuan.Text
        End If

        If CheckBukuAjar.Checked = True Then
            Buku = Buku & CheckBukuAjar.Text & ", "
        End If
        If CheckBukuKamus.Checked = True Then
            Buku = Buku & CheckBukuKamus.Text & ", "
        End If
        If CheckBukuEnsiklopedia.Checked = True Then
            Buku = Buku & CheckBukuEnsiklopedia.Text & ", "
        End If
        If CheckBukuDirektori.Checked = True Then
            Buku = Buku & CheckBukuDirektori.Text & ", "
        End If

        MessageBox.Show("Nama : " & TxtNama.Text & vbCrLf & "NIM : " & TxtNIM.Text & vbCrLf & "Jenis Kelamin : " & JK & vbCrLf & "Kelas : " & ComboKelas.Text & vbCrLf & "Buku : " & Buku & vbCrLf & "Tanggal Pinjam : " & DateTimePicker1.Text & vbCrLf & "Tanggal Batas Pengembalian : " & DateTimePicker2.Text, "Hasil Pengisian", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Login.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd MMMM yyyy"
        DateTimePicker1.Value = Format(Now)

        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "dd MMMM yyyy"
        DateTimePicker2.Value = Format(Now)
    End Sub

    Private Sub TxtNIM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNIM.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub TxtNama_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNama.KeyDown
        If e.KeyCode = 48 Or e.KeyCode = 49 Or e.KeyCode = 50 Or e.KeyCode = 51 Or e.KeyCode = 52 Or e.KeyCode = 53 Or e.KeyCode = 54 Or e.KeyCode = 55 Or e.KeyCode = 56 Or e.KeyCode = 57 Then
            TxtNama.ReadOnly = True
        Else
            TxtNama.ReadOnly = False
        End If
    End Sub
End Class
