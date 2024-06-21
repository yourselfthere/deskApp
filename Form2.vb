
Imports System.Net.Http
Imports System.Text.Json

Public Class Form2


    Private currentIndex As Integer = 0
    Private totalSubmissions As Integer = 0
    Private isEditMode As Boolean = False

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

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim index As Integer = currentIndex
        Dim url As String = $"http://localhost:3000/delete?index={index}"

        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.DeleteAsync(url)
                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission deleted successfully.")
                    ' Refresh the view or navigate to the next/previous submission
                    If currentIndex > 0 Then
                        currentIndex -= 1
                    End If
                    Await LoadSubmission(currentIndex, "")
                Else
                    MessageBox.Show("Failed to delete submission. Status code: " & response.StatusCode.ToString())
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Async Function SearchSubmissionByEmail(email As String) As Task
        Using client As New HttpClient()
            Dim apiUrl As String = $"http://localhost:3000/search?email={email}"
            Dim response As HttpResponseMessage = Await client.GetAsync(apiUrl)

            If response.IsSuccessStatusCode Then
                Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                Dim result = JsonSerializer.Deserialize(Of Dictionary(Of String, JsonElement))(jsonResponse)

                ' Update the currentIndex with the index of the found submission
                currentIndex = result("index").GetInt32()

                ' Update the text boxes with the submission data
                Dim submission = JsonSerializer.Deserialize(Of Submission)(result("submission").ToString())
                TxtNBox.Text = submission.name
                TxtEBox.Text = submission.email
                TxtPBox.Text = submission.phone
                TxtGBox.Text = submission.github_link
                TxtSBox.Text = submission.stopwatch_time
            Else
                MessageBox.Show("Error: " & response.ReasonPhrase)
            End If
        End Using
    End Function

    Private Async Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim email As String = txtSearchEmail.Text
        If Not String.IsNullOrEmpty(email) Then
            Await SearchSubmissionByEmail(email)
        Else
            MessageBox.Show("Please enter an email ID.")
        End If
    End Sub
    Private Async Function EditSubmission(index As Integer, name As String, email As String, phone As String, github_link As String, stopwatch_time As String) As Task
        Dim url As String = $"http://localhost:3000/edit?index={index}"
        Dim content = New FormUrlEncodedContent(New Dictionary(Of String, String) From {
            {"name", name},
            {"email", email},
            {"phone", phone},
            {"github_link", github_link},
            {"stopwatch_time", stopwatch_time}
        })

        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.PutAsync(url, content)

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission updated successfully.")
                ' Reload the submission after edit
                Await LoadSubmission(index, "")
            Else
                MessageBox.Show("Failed to update submission. Status code: " & response.StatusCode.ToString())
            End If
        End Using
    End Function

    Private Async Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If isEditMode Then
            ' Submit the edited version
            Dim name As String = TxtNBox.Text
            Dim email As String = TxtEBox.Text
            Dim phone As String = TxtPBox.Text
            Dim github_link As String = TxtGBox.Text
            Dim stopwatch_time As String = TxtSBox.Text

            If String.IsNullOrEmpty(name) OrElse String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(phone) OrElse String.IsNullOrEmpty(github_link) OrElse String.IsNullOrEmpty(stopwatch_time) Then
                MessageBox.Show("All fields are required.")
                Return
            End If

            Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to update this submission?", "Confirmation", MessageBoxButtons.YesNo)
            If confirmResult = DialogResult.Yes Then
                Await EditSubmission(currentIndex, name, email, phone, github_link, stopwatch_time)
            End If

            ' Set text boxes back to read-only mode
            TxtNBox.ReadOnly = True
            TxtNBox.BackColor = SystemColors.ControlDark
            TxtEBox.ReadOnly = True
            TxtEBox.BackColor = SystemColors.ControlDark
            TxtPBox.ReadOnly = True
            TxtPBox.BackColor = SystemColors.ControlDark
            TxtGBox.ReadOnly = True
            TxtGBox.BackColor = SystemColors.ControlDark
            TxtSBox.ReadOnly = True
            btnEdit.Text = "Edit"
            isEditMode = False
        Else
            ' Set text boxes to editable mode
            TxtNBox.ReadOnly = False
            TxtNBox.BackColor = SystemColors.Control





            TxtEBox.ReadOnly = False
            TxtEBox.BackColor = SystemColors.Control
            TxtPBox.ReadOnly = False
            TxtPBox.BackColor = SystemColors.Control
            TxtGBox.ReadOnly = False
            TxtGBox.BackColor = SystemColors.Control

            btnEdit.Text = "Save"
            isEditMode = True
        End If
    End Sub



End Class