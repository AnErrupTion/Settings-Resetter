Imports System.IO
Imports System.Threading

Public Class Main
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        TextBox1.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\" & Path.GetFileNameWithoutExtension(TextBox1.Text).Replace(" ", "_"), True)
            Thread.Sleep(1000)
            MsgBox("Sucessfully resetted the software's settings!")
        Catch ex As Exception
            MsgBox("Couldn't reset the choosed software's settings : " & ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Not TextBox1.Text = Nothing Then Button1.Enabled = True Else Button1.Enabled = False
    End Sub
End Class
