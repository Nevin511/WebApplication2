Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports WebApplication2

Namespace Controllers
    Public Class CollegesController
        Inherits System.Web.Mvc.Controller

        Private db As New DataSource

        ' GET: Colleges

        Function Index() As ActionResult
            Return View(db.Colleges.ToList())
        End Function

        ' GET: Colleges/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim college As College = db.Colleges.Find(id)
            If IsNothing(college) Then
                Return HttpNotFound()
            End If
            Return View(college)
        End Function

        ' GET: Colleges/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Colleges/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="CollegeID,CollegeName")> ByVal college As College) As ActionResult
            If ModelState.IsValid Then
                db.Colleges.Add(college)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(college)
        End Function

        ' GET: Colleges/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim college As College = db.Colleges.Find(id)
            If IsNothing(college) Then
                Return HttpNotFound()
            End If
            Return View(college)
        End Function

        ' POST: Colleges/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="CollegeID,CollegeName")> ByVal college As College) As ActionResult
            If ModelState.IsValid Then
                db.Entry(college).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(college)
        End Function

        ' GET: Colleges/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim college As College = db.Colleges.Find(id)
            If IsNothing(college) Then
                Return HttpNotFound()
            End If
            Return View(college)
        End Function

        ' POST: Colleges/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim college As College = db.Colleges.Find(id)
            db.Colleges.Remove(college)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
