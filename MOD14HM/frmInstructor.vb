Imports MOD14HM.ClassInherit

Public Class frmInstructor

    Dim Inst As New Instructors


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Inst.FirstName = instFirst.Text
        Inst.LastName = instLast.Text
        Inst.Email = InsEmail.Text
        Inst.OfficeNumber = InstOffice.Text



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtInstructor.Text = "Instructor Name: " + Inst.FirstName + Inst.LastName + " Email: " + Inst.Email + " Office Number: " + Inst.OfficeNumber


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim export As IO.StreamWriter = IO.File.CreateText("C:\Users\Francisco Bumanglag\Desktop\CE_INSTRUCTOR.csv")

        export.WriteLine(Inst.FirstName & "," & Inst.LastName & "," & Inst.Email & "," & Inst.OfficeNumber)

        export.Close()   'If this line is omitted, the file will be empty.
        MessageBox.Show("Your instructor information was saved and exported to a csv file.  Please check your desktop for the CE_INSTRUCTOR file")


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Close()
        Form1.Show()

    End Sub

    Private Sub frmInstructor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub
End Class