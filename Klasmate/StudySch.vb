﻿Imports Klasmate

Public Class StudySch
    Private Id As Integer
    Private Name As String
    Private Schedule As Schedule
    Private Color As Color

    Public Property Id_StudySch As Integer
        Get
            Return Id
        End Get
        Set(value As Integer)
            Id = value
        End Set
    End Property

    Public Property Name_StudySch As String
        Get
            Return Name
        End Get
        Set(value As String)
            Name = value
        End Set
    End Property

    Public Property Schedule_StudySch As Schedule
        Get
            Return Schedule
        End Get
        Set(value As Schedule)
            Schedule = value
        End Set
    End Property

    Public Property Color_StudySch As Color
        Get
            Return Color
        End Get
        Set(value As Color)
            Color = value
        End Set
    End Property
End Class
