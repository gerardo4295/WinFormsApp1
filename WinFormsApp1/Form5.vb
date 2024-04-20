Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Start the loading process when Form5 is loaded
        StartLoading()
    End Sub

    ' Method to start the loading process
    Private Sub StartLoading()
        ' Set the ProgressBar to indeterminate mode to show loading animation
        ProgressBar1.Style = ProgressBarStyle.Marquee

        ' Create a timer to control the duration of the loading
        Dim timer As New Timer()
        timer.Interval = 5000 ' 5 seconds
        AddHandler timer.Tick, AddressOf Timer_Tick
        timer.Start()
    End Sub

    ' Event handler for the timer tick event
    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        ' Stop the timer
        Dim timer As Timer = CType(sender, Timer)
        timer.Stop()

        ' Switch to Form6
        Dim form6 As New Form6()
        form6.Show()

        ' Close the current form
        Me.Close()
    End Sub
End Class

