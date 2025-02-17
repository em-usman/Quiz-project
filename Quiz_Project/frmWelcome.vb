Public Class frmWelcome

    Private Sub frmWelcome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Welcome, AudioPlayMode.Background)
        Label2.Text = Date.Now.ToShortDateString
        Label3.Text = Date.Now.ToShortTimeString
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.PerformStep()
        If ProgressBar1.Value >= ProgressBar1.Maximum Then
            Timer1.Stop()
            Me.Visible = False
            Login.Visible = True

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
