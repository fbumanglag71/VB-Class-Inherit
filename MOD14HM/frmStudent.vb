Imports MOD14HM.ClassInherit

Public Class frmStudent

    Dim Stu As New Students

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Stu.Firstname = stuFirst.Text
        Stu.LastName = stuLast.Text
        Stu.Email = studEmail.Text
        Stu.StudentNumber = stuNumber.Text


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtStudent.Text = "Student Name: " + Stu.FirstName + Stu.LastName + " Email: " + Stu.Email + " Student Number: " + Stu.StudentNumber

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim export As IO.StreamWriter = IO.File.CreateText("C:\Users\Francisco Bumanglag\Desktop\CE_Student.csv")

        export.WriteLine(Stu.FirstName & "," & Stu.LastName & "," & Stu.Email & "," & Stu.StudentNumber)

        export.Close()   'If this line is omitted, the file will be empty.
        MessageBox.Show("Your student information was saved and exported to a csv file.  Please check your desktop for the CE_STUDENT file")


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Close()
        Form1.Show()

    End Sub

    Private Sub frmStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub
End Class