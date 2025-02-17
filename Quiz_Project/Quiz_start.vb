Public Class Quiz_start
    Dim seccount As Integer

    Private Sub Quiz_start_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Quiz_databaseDataSet.Questions' table. You can move, or remove it, as needed.
        Me.QuestionsTableAdapter.Fill(Me.Quiz_databaseDataSet.Questions)
        seccount = 500
        Timer1.Enabled = True

    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        If answer = TextBox1.Text Then
            marks = marks + 5

        Else
            marks = marks

        End If
        If Me.BindingSource1.Position + 1 < Me.BindingSource1.Count Then

            Me.BindingSource1.MoveNext()
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
        Else
            Timer1.Enabled = False
            Me.Hide()
            frmResult.Show()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            answer = RadioButton1.Text
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            answer = RadioButton2.Text
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            answer = RadioButton3.Text
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            answer = RadioButton4.Text
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Static seconds
        seconds = seconds + 1
        lblCount.Text = seccount - seconds
        If seconds = seccount Then
            MessageBox.Show("Sorry, time over", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Timer1.Enabled = False
            Application.Exit()
        End If
    End Sub
End Class