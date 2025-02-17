<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quiz_start
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Quiz_databaseDataSet = New Quiz_Project.Quiz_databaseDataSet()
        Me.QuestionsTableAdapter = New Quiz_Project.Quiz_databaseDataSetTableAdapters.QuestionsTableAdapter()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.gbChoice = New System.Windows.Forms.GroupBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblCount = New System.Windows.Forms.Label()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Quiz_databaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbChoice.SuspendLayout()
        Me.SuspendLayout()
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Questions"
        Me.BindingSource1.DataSource = Me.Quiz_databaseDataSet
        '
        'Quiz_databaseDataSet
        '
        Me.Quiz_databaseDataSet.DataSetName = "Quiz_databaseDataSet"
        Me.Quiz_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QuestionsTableAdapter
        '
        Me.QuestionsTableAdapter.ClearBeforeFill = True
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Question", True))
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.ForeColor = System.Drawing.Color.White
        Me.lblQuestion.Location = New System.Drawing.Point(12, 29)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(55, 16)
        Me.lblQuestion.TabIndex = 0
        Me.lblQuestion.Text = "Label1"
        '
        'gbChoice
        '
        Me.gbChoice.Controls.Add(Me.RadioButton4)
        Me.gbChoice.Controls.Add(Me.RadioButton3)
        Me.gbChoice.Controls.Add(Me.RadioButton2)
        Me.gbChoice.Controls.Add(Me.RadioButton1)
        Me.gbChoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbChoice.ForeColor = System.Drawing.Color.White
        Me.gbChoice.Location = New System.Drawing.Point(15, 70)
        Me.gbChoice.Name = "gbChoice"
        Me.gbChoice.Size = New System.Drawing.Size(361, 175)
        Me.gbChoice.TabIndex = 1
        Me.gbChoice.TabStop = False
        Me.gbChoice.Text = "Options"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Option4", True))
        Me.RadioButton4.ForeColor = System.Drawing.Color.White
        Me.RadioButton4.Location = New System.Drawing.Point(6, 134)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(112, 19)
        Me.RadioButton4.TabIndex = 5
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "RadioButton4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Option3", True))
        Me.RadioButton3.ForeColor = System.Drawing.Color.White
        Me.RadioButton3.Location = New System.Drawing.Point(6, 99)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(112, 19)
        Me.RadioButton3.TabIndex = 4
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Option2", True))
        Me.RadioButton2.ForeColor = System.Drawing.Color.White
        Me.RadioButton2.Location = New System.Drawing.Point(6, 61)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(112, 19)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Option1", True))
        Me.RadioButton1.ForeColor = System.Drawing.Color.White
        Me.RadioButton1.Location = New System.Drawing.Point(6, 29)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(112, 19)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Correct_Answer", True))
        Me.TextBox1.Location = New System.Drawing.Point(21, 270)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(117, 20)
        Me.TextBox1.TabIndex = 6
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(442, 220)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 25)
        Me.btnSubmit.TabIndex = 7
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.ForeColor = System.Drawing.Color.White
        Me.lblCount.Location = New System.Drawing.Point(513, 9)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(55, 16)
        Me.lblCount.TabIndex = 8
        Me.lblCount.Text = "Label1"
        '
        'Quiz_start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(562, 257)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.gbChoice)
        Me.Controls.Add(Me.lblQuestion)
        Me.MaximizeBox = False
        Me.Name = "Quiz_start"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quiz Start"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Quiz_databaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbChoice.ResumeLayout(False)
        Me.gbChoice.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Quiz_databaseDataSet As Quiz_Project.Quiz_databaseDataSet
    Friend WithEvents QuestionsTableAdapter As Quiz_Project.Quiz_databaseDataSetTableAdapters.QuestionsTableAdapter
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents gbChoice As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblCount As System.Windows.Forms.Label
End Class
