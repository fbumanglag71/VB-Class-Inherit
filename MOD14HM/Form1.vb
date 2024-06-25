Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Hide()               'hide the main form 
        frmCourse.Show()        'open the course form

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Hide()               'hide the main form
        frmStudent.Show()       'open the student form

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Hide()               'hide the main form
        frmInstructor.Show()    'open the instructor form

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Me.Close()              'close the program

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()     'center the form 

    End Sub


End Class
