Imports System.Net.Http
Imports System.Text
Imports System.Text.Json

Public Class Form3


    Private stopwatchRunning As Boolean = False
    Private stopwatchTime As TimeSpan = TimeSpan.Zero

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set initial stopwatch label text
        LblStopwatch.Text = stopwatchTime.ToString("hh\:mm\:ss")
        ' Initialize Timer
        TimerStopwatch.Interval = 1000 ' 1 second
    End Sub


    Private Sub BtnPauseResume_Click(sender As Object, e As EventArgs) Handles BtnPauseResume.Click
        ' MsgBox("Stopwatch")
        If stopwatchRunning Then
            ' Pause the stopwatch
            TimerStopwatch.Stop()
            BtnPauseResume.Text = "Resume"
        Else
            ' Start the stopwatch
            TimerStopwatch.Start()
            BtnPauseResume.Text = "Pause"
        End If
        stopwatchRunning = Not stopwatchRunning
    End Sub
    Private Sub TimerStopwatch_Tick(sender As Object, e As EventArgs) Handles TimerStopwatch.Tick
        ' Update stopwatch time
        stopwatchTime = stopwatchTime.Add(TimeSpan.FromSeconds(1))
        ' Update label text
        LblStopwatch.Text = stopwatchTime.ToString("hh\:mm\:ss")
    End Sub

    Private Async Sub BtnSub_Click(sender As Object, e As EventArgs) Handles BtnSub.Click
        MsgBox("Submitted!!")
        Dim name As String = TxtNBox.Text
        Dim email As String = TxtEBox.Text
        Dim phone As String = TxtPBox.Text
        Dim githubLink As String = TxtGBox.Text
        ' Dim stopwatchTime As String = "00:00:00"


        Dim submission As New With {
         .name = name,
         .email = email,
         .phone = phone,
         .github_link = githubLink,
         .stopwatch_time = stopwatchTime.ToString("hh\:mm\:ss")}

        Dim jsonData As String = JsonSerializer.Serialize(submission)

        Using client As New HttpClient()
            Dim content As New StringContent(jsonData, Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission successful!")
            Else
                MessageBox.Show("Error: " & response.ReasonPhrase)
            End If
        End Using
        Me.Hide()

        ' Show Form3
        Dim form1 As New Form1()
        form1.ShowDialog()

        ' Close Form1 after Form3 is closed (optional)
        Me.Close()

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click

        Me.Hide()

        ' Show Form2
        Dim form1 As New Form1()
        form1.ShowDialog()

        ' Close Form1 after Form2 is closed (optional)
        Me.Close()
    End Sub

    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            ' Handle Ctrl + N shortcut (Next button action)
            BtnSub.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            ' Handle Ctrl + P shortcut (Previous button action)
            BtnPauseResume.PerformClick()
        End If
    End Sub


End Class