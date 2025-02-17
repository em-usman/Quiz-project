Public Class Login

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Instruction, AudioPlayMode.Background)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        If txtLogin.Text = "" Then
            MessageBox.Show("Please enter your name", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtLogin.Focus()
        Else
            nm = txtLogin.Text
            Me.Hide()
            Quiz_start.Show()
            Quiz_start.RadioButton1.Checked = False
            Quiz_start.RadioButton2.Checked = False
            Quiz_start.RadioButton3.Checked = False
            Quiz_start.RadioButton4.Checked = False
        End If

    End Sub
End Class