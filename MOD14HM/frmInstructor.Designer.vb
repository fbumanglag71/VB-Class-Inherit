<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInstructor
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
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtInstructor = New System.Windows.Forms.TextBox()
        Me.InstOffice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.InsEmail = New System.Windows.Forms.TextBox()
        Me.instEmail = New System.Windows.Forms.Label()
        Me.instLast = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.instFirst = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(680, 111)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 120
        Me.Button3.Text = "QUIT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(268, 111)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(228, 23)
        Me.Button2.TabIndex = 119
        Me.Button2.Text = "DISPLAY INFORMATION"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 111)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(228, 23)
        Me.Button1.TabIndex = 118
        Me.Button1.Text = "SAVE INFORMATION"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(28, 179)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 15)
        Me.Label17.TabIndex = 117
        Me.Label17.Text = "INSTRUCTOR"
        '
        'txtInstructor
        '
        Me.txtInstructor.Location = New System.Drawing.Point(124, 176)
        Me.txtInstructor.Name = "txtInstructor"
        Me.txtInstructor.Size = New System.Drawing.Size(650, 23)
        Me.txtInstructor.TabIndex = 116
        '
        'InstOffice
        '
        Me.InstOffice.Location = New System.Drawing.Point(697, 21)
        Me.InstOffice.Name = "InstOffice"
        Me.InstOffice.Size = New System.Drawing.Size(58, 23)
        Me.InstOffice.TabIndex = 115
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(639, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 15)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "Inst Off#"
        '
        'InsEmail
        '
        Me.InsEmail.Location = New System.Drawing.Point(449, 24)
        Me.InsEmail.Name = "InsEmail"
        Me.InsEmail.Size = New System.Drawing.Size(166, 23)
        Me.InsEmail.TabIndex = 113
        '
        'instEmail
        '
        Me.instEmail.AutoSize = True
        Me.instEmail.Location = New System.Drawing.Point(391, 27)
        Me.instEmail.Name = "instEmail"
        Me.instEmail.Size = New System.Drawing.Size(58, 15)
        Me.instEmail.TabIndex = 112
        Me.instEmail.Text = "Inst Email"
        '
        'instLast
        '
        Me.instLast.Location = New System.Drawing.Point(258, 24)
        Me.instLast.Name = "instLast"
        Me.instLast.Size = New System.Drawing.Size(100, 23)
        Me.instLast.TabIndex = 111
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Inst LN"
        '
        'instFirst
        '
        Me.instFirst.Location = New System.Drawing.Point(78, 21)
        Me.instFirst.Name = "instFirst"
        Me.instFirst.Size = New System.Drawing.Size(100, 23)
        Me.instFirst.TabIndex = 109
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 15)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Inst FN"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(529, 111)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(134, 23)
        Me.Button4.TabIndex = 121
        Me.Button4.Text = "EXPORT TO CSV"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frmInstructor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 256)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtInstructor)
        Me.Controls.Add(Me.InstOffice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.InsEmail)
        Me.Controls.Add(Me.instEmail)
        Me.Controls.Add(Me.instLast)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.instFirst)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmInstructor"
        Me.Text = "frmInstructor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents txtInstructor As TextBox
    Friend WithEvents InstOffice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents InsEmail As TextBox
    Friend WithEvents instEmail As Label
    Friend WithEvents instLast As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents instFirst As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
End Class
