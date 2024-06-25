<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudent
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtStudent = New System.Windows.Forms.TextBox()
        Me.stuNumber = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.studEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.stuLast = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.stuFirst = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(678, 125)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 120
        Me.Button3.Text = "QUIT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(257, 125)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(188, 23)
        Me.Button2.TabIndex = 119
        Me.Button2.Text = "DISPLAY INFORMATION"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(43, 125)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 23)
        Me.Button1.TabIndex = 118
        Me.Button1.Text = "SAVE INFORMATION"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(44, 189)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 15)
        Me.Label18.TabIndex = 117
        Me.Label18.Text = "STUDENT"
        '
        'txtStudent
        '
        Me.txtStudent.Location = New System.Drawing.Point(116, 181)
        Me.txtStudent.Name = "txtStudent"
        Me.txtStudent.Size = New System.Drawing.Size(650, 23)
        Me.txtStudent.TabIndex = 116
        '
        'stuNumber
        '
        Me.stuNumber.Location = New System.Drawing.Point(708, 23)
        Me.stuNumber.Name = "stuNumber"
        Me.stuNumber.Size = New System.Drawing.Size(80, 23)
        Me.stuNumber.TabIndex = 115
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(635, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 15)
        Me.Label7.TabIndex = 114
        Me.Label7.Text = "Stu Number"
        '
        'studEmail
        '
        Me.studEmail.Location = New System.Drawing.Point(450, 23)
        Me.studEmail.Name = "studEmail"
        Me.studEmail.Size = New System.Drawing.Size(166, 23)
        Me.studEmail.TabIndex = 113
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(387, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 15)
        Me.Label6.TabIndex = 112
        Me.Label6.Text = "Stu Email"
        '
        'stuLast
        '
        Me.stuLast.Location = New System.Drawing.Point(259, 23)
        Me.stuLast.Name = "stuLast"
        Me.stuLast.Size = New System.Drawing.Size(100, 23)
        Me.stuLast.TabIndex = 111
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(196, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 15)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Stu LN"
        '
        'stuFirst
        '
        Me.stuFirst.Location = New System.Drawing.Point(79, 23)
        Me.stuFirst.Name = "stuFirst"
        Me.stuFirst.Size = New System.Drawing.Size(100, 23)
        Me.stuFirst.TabIndex = 109
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "Stu FN"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(504, 125)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(124, 23)
        Me.Button4.TabIndex = 121
        Me.Button4.Text = "EXPORT TO CSV"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frmStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 256)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtStudent)
        Me.Controls.Add(Me.stuNumber)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.studEmail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.stuLast)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.stuFirst)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmStudent"
        Me.Text = "frmStudent"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents txtStudent As TextBox
    Friend WithEvents stuNumber As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents studEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents stuLast As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents stuFirst As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
End Class
