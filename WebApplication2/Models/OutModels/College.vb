Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class College
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property CollegeID As Integer

    <Required>
    <StringLength(20)>
    Public Property CollegeName As String
End Class
