<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCourse
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
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtCourses = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.courUnits = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.courRoom = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.courName = New System.Windows.Forms.TextBox()
        Me.courNum = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(688, 131)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 120
        Me.Button3.Text = "QUIT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(279, 131)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(228, 23)
        Me.Button2.TabIndex = 119
        Me.Button2.Text = "DISPLAY INFORMATION"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 131)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(228, 23)
        Me.Button1.TabIndex = 118
        Me.Button1.Text = "SAVE INFORMATION"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(21, 194)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(51, 15)
        Me.Label19.TabIndex = 117
        Me.Label19.Text = "COURSE"
        '
        'txtCourses
        '
        Me.txtCourses.Location = New System.Drawing.Point(95, 191)
        Me.txtCourses.Name = "txtCourses"
        Me.txtCourses.Size = New System.Drawing.Size(650, 23)
        Me.txtCourses.TabIndex = 116
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(454, 29)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 15)
        Me.Label16.TabIndex = 115
        Me.Label16.Text = "Cour Units"
        '
        'courUnits
        '
        Me.courUnits.Location = New System.Drawing.Point(523, 26)
        Me.courUnits.Name = "courUnits"
        Me.courUnits.Size = New System.Drawing.Size(56, 23)
        Me.courUnits.TabIndex = 110
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(590, 29)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 15)
        Me.Label15.TabIndex = 114
        Me.Label15.Text = "Cour RM"
        '
        'courRoom
        '
        Me.courRoom.Location = New System.Drawing.Point(652, 26)
        Me.courRoom.Name = "courRoom"
        Me.courRoom.Size = New System.Drawing.Size(56, 23)
        Me.courRoom.TabIndex = 111
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(227, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 15)
        Me.Label9.TabIndex = 113
        Me.Label9.Text = "Cour Name"
        '
        'courName
        '
        Me.courName.Location = New System.Drawing.Point(301, 23)
        Me.courName.Name = "courName"
        Me.courName.Size = New System.Drawing.Size(100, 23)
        Me.courName.TabIndex = 109
        '
        'courNum
        '
        Me.courNum.Location = New System.Drawing.Point(106, 23)
        Me.courNum.Name = "courNum"
        Me.courNum.Size = New System.Drawing.Size(100, 23)
        Me.courNum.TabIndex = 108
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(59, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 15)
        Me.Label8.TabIndex = 112
        Me.Label8.Text = "Cour#"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(537, 131)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(122, 23)
        Me.Button4.TabIndex = 121
        Me.Button4.Text = "EXPORT TO CSV"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frmCourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 280)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtCourses)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.courUnits)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.courRoom)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.courName)
        Me.Controls.Add(Me.courNum)
        Me.Controls.Add(Me.Label8)
        Me.Name = "frmCourse"
        Me.Text = "frmCourse"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents txtCourses As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents courUnits As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents courRoom As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents courName As TextBox
    Friend WithEvents courNum As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button4 As Button
End Class
