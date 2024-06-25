Public Class ClassInherit

    MustInherit Class Person

        Public Property FirstName As String
        Public Property LastName As String
        Public Property Email As String
        MustOverride Function Choice() As String

    End Class    'Enrollment

    Class Students

        Inherits Person

        Public Property StudentNumber As String

        Overrides Function Choice() As String
            Return ""
        End Function

    End Class    'Student


    Class Instructors

        Inherits Person

        Public Property OfficeNumber As String

        Overrides Function Choice() As String
            Return ""
        End Function

    End Class    'Instructor

    Class Courses

        Public Property CourseNumber As String
        Public Property CourseName As String
        Public Property CourseUnits As String

        Public Property RoomNumber As String

    End Class    'Course 


End Class       'form enrollment







