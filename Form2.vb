Public Class Form2

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim mainForm As New Form1()
        mainForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub


End Class