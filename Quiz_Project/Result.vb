Public Class frmResult

    Private Sub frmResult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If marks >= 40 Then
            lblmessage.Text = "Congratulations! You have passed the quiz"
            lblmarks.BackColor = Color.LightYellow
            lblmarks.ForeColor = Color.DarkSeaGreen
        Else
            lblmessage.Text = "Sorry! please try again"
            lblmarks.BackColor = Color.LightYellow
            lblmarks.ForeColor = Color.IndianRed
        End If
        lblname.Text = nm
        lblmarks.Text = marks.ToString
    End Sub

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        Application.Exit()
    End Sub
End Class