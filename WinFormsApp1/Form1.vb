Public Class Form1
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim form2 As New Form2()
        form2.Show()
        Me.Hide()
    End Sub
End Class

