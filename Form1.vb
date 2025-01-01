Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Or RadioButton2.Checked Then

            ProgressBar1.Value = 1 ' fallback?
            While Not ProgressBar1.Value = 100
                ProgressBar1.Value += 1
                Threading.Thread.Sleep(ProgressBar1.Value)
            End While

            Dim stringxd As Integer = 0
            While Not stringxd = 100
                ToolStripStatusLabel1.Text = "Exract " & stringxd.ToString() & "[TMP].pkg.bin"
                stringxd += 1
                ProgressBar1.Value = stringxd
                Threading.Thread.Sleep(1)
                Application.DoEvents()
            End While
            stringxd = 0
            While Not stringxd = 100
                ToolStripStatusLabel1.Text = "Unpak " & stringxd.ToString() & ".bin"
                stringxd += 1
                ProgressBar1.Value = stringxd
                Threading.Thread.Sleep(40)
                Application.DoEvents()
            End While
            stringxd = 0
            While Not stringxd = 100
                ToolStripStatusLabel1.Text = "Ital " & stringxd.ToString() & "__::__" & stringxd.ToString() & ".exe"
                stringxd += 1
                ProgressBar1.Value = stringxd
                Threading.Thread.Sleep(14)
                Application.DoEvents()
            End While
            stringxd = 0
            While Not stringxd = 100
                ToolStripStatusLabel1.Text = "Tstin APP_" & stringxd.ToString() & ".apk"
                stringxd += 1
                ProgressBar1.Value = stringxd
                Threading.Thread.Sleep(2)
                Application.DoEvents()
            End While

            Form2.ShowDialog()

        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            Button1.Text = "ISTAL [root] ADROD NO FAKE REAL REAL NOVIRUS MAGISK SUPERSUs"
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            Button1.Text = "ISTAL ADROD NO FAKE REAL REAL NOVIRUS"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.ShowDialog()
    End Sub
End Class
