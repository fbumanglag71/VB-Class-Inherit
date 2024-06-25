'' Author: Francisco Bumanglag
'' Project: Main and 3 Sub Form -- Class Inherit
'' Assignment: Module 14 Homework
'' Course: Visual Basic, Santa Ana College
'' Class: CMPR105 Derendal Huynh 
'' Date: November 27, 2022


Imports MOD14HM.ClassInherit

Public Class frmCourse

    Dim Cour As New Courses
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cour.CourseNumber = courNum.Text
        Cour.CourseName = courName.Text
        Cour.CourseUnits = courUnits.Text
        Cour.RoomNumber = courRoom.Text


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        txtCourses.Text = "Course#: " + Cour.CourseNumber + " Course Name: " + Cour.CourseName + " Units: " + Cour.CourseUnits + " Room#: " + Cour.RoomNumber


    End Sub

    Private Sub frmCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim export As IO.StreamWriter = IO.File.CreateText("C:\Users\Francisco Bumanglag\Desktop\CE_COURSE.csv")

        export.WriteLine(Cour.CourseNumber & "," & Cour.CourseName & "," & Cour.CourseUnits & "," & Cour.RoomNumber)

        export.Close()   'If this line is omitted, the file will be empty.
        MessageBox.Show("Your course information was saved and exported to a csv file.  Please check your desktop for the CE_COURSE file")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Close()
        Form1.Show()

    End Sub
End Class