Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Student
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property StudentID As Integer

    <StringLength(20)>
    Public Property FirstName As String

    <StringLength(20)>
    Public Property LastName As String

    <StringLength(50)>
    Public Property Email As String

    Public Property CollegeID As Integer?
End Class
