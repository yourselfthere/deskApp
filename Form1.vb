Public Class Form1
    Private Sub BtnView_Click(sender As Object, e As EventArgs) Handles BtnView.Click

        Me.Hide()

        ' Show Form2
        Dim form2 As New Form2()
        form2.ShowDialog()

        ' Close Form1 after Form2 is closed (optional)
        Me.Close()

    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click

        Me.Hide()

        ' Show Form3
        Dim form3 As New Form3()
        form3.ShowDialog()

        ' Close Form1 after Form3 is closed (optional)
        Me.Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            ' Handle Ctrl + N shortcut (Next button action)
            BtnView.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            ' Handle Ctrl + P shortcut (Previous button action)
            BtnCreate.PerformClick()
        End If
    End Sub
End Class
