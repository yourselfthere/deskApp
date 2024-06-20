
Imports System.Net.Http
Imports System.Text.Json

Public Class Form2


    Private currentIndex As Integer = 0
    Private totalSubmissions As Integer = 0


    Private Async Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadSubmission(currentIndex,"")
    End Sub

    Private Async Sub Nex_Click(sender As Object, e As EventArgs) Handles Nex.Click

        ' If currentIndex < totalSubmissions + 1 Then
        currentIndex += 1
            Await LoadSubmission(currentIndex, "next")
        ' End If


    End Sub

    Private Async Sub Prev_Click(sender As Object, e As EventArgs) Handles Prev.Click

        If currentIndex > 0 Then
            currentIndex -= 1
            Await LoadSubmission(currentIndex, "prev")
        End If
    End Sub


    Private Async Function LoadSubmission(index As Integer, action As String) As Task
        Using client As New HttpClient()
            Dim apiUrl As String = $"http://localhost:3000/read?index={index}&action={action}"
            Dim response As HttpResponseMessage = Await client.GetAsync(apiUrl)

            If response.IsSuccessStatusCode Then
                Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                Dim submission = JsonSerializer.Deserialize(Of Submission)(jsonResponse)

                TxtNBox.Text = submission.name
                TxtEBox.Text = submission.email
                TxtPBox.Text = submission.phone
                TxtGBox.Text = submission.github_link
                TxtSBox.Text = submission.stopwatch_time
            Else
                MessageBox.Show("Error: " & response.ReasonPhrase)
                currentIndex -= 1

            End If
        End Using
    End Function




    Private Class Submission
        Public Property name As String
        Public Property email As String
        Public Property phone As String
        Public Property github_link As String
        Public Property stopwatch_time As String
    End Class




    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click

        Me.Hide()

        ' Show Form2
        Dim form1 As New Form1()
        form1.ShowDialog()

        ' Close Form1 after Form2 is closed (optional)
        Me.Close()
    End Sub



    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.N Then
            ' Handle Ctrl + N shortcut (Next button action)
            Nex.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.P Then
            ' Handle Ctrl + P shortcut (Previous button action)
            Prev.PerformClick()
        End If
    End Sub





End Class