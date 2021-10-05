Imports System
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity
Imports System.Linq

Partial Public Class DataSource
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=DataSource")
    End Sub

    Public Overridable Property Colleges As DbSet(Of College)
    Public Overridable Property Students As DbSet(Of Student)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of College)() _
            .Property(Function(e) e.CollegeName) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Student)() _
            .Property(Function(e) e.FirstName) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Student)() _
            .Property(Function(e) e.LastName) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Student)() _
            .Property(Function(e) e.Email) _
            .IsUnicode(False)
    End Sub
End Class
