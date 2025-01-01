Public Class Form2
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        MessageBox.Show("u phon is brik")
        While True
            ' 0 - 1
            Dim randomOpacity As Single = Rnd()

            Me.Opacity = randomOpacity
            Me.Size = New Size(randomOpacity, randomOpacity)
            Me.Width = (randomOpacity + 1) * 100
            Me.Height = (randomOpacity + 1) * 100
            Me.Name = randomOpacity * randomOpacity * 1000

            Me.BringToFront()

            System.Threading.Thread.Sleep(1)
        End While
    End Sub



    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        MessageBox.Show("ther no gaems u hon is fre versin and nly the paid one hav gaems")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("eror")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        MessageBox.Show("dont fucking touche me this way your bastard")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("no wif i")
    End Sub
End Class