Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports FootbalTeams

Namespace Controllers
    Public Class TeamDetailsController
        Inherits System.Web.Mvc.Controller

        Private db As New FootballTeamsEntities

        ' GET: TeamDetails
        Function Index() As ActionResult
            Dim teamDetails = db.TeamDetails.Include(Function(t) t.Player)
            Return View(teamDetails.ToList())
        End Function

        ' GET: TeamDetails/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim teamDetail As TeamDetail = db.TeamDetails.Find(id)
            If IsNothing(teamDetail) Then
                Return HttpNotFound()
            End If
            Return View(teamDetail)
        End Function

        ' GET: TeamDetails/Create
        Function Create() As ActionResult
            ViewBag.ID = New SelectList(db.Players, "PlayerID", "FirstName")
            Return View()
        End Function

        ' POST: TeamDetails/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ID,Name,City,Stadium,YearOfCreating,History")> ByVal teamDetail As TeamDetail) As ActionResult
            If ModelState.IsValid Then
                db.TeamDetails.Add(teamDetail)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.ID = New SelectList(db.Players, "PlayerID", "FirstName", teamDetail.ID)
            Return View(teamDetail)
        End Function

        ' GET: TeamDetails/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim teamDetail As TeamDetail = db.TeamDetails.Find(id)
            If IsNothing(teamDetail) Then
                Return HttpNotFound()
            End If
            ViewBag.ID = New SelectList(db.Players, "PlayerID", "FirstName", teamDetail.ID)
            Return View(teamDetail)
        End Function

        ' POST: TeamDetails/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ID,Name,City,Stadium,YearOfCreating,History")> ByVal teamDetail As TeamDetail) As ActionResult
            If ModelState.IsValid Then
                db.Entry(teamDetail).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.ID = New SelectList(db.Players, "PlayerID", "FirstName", teamDetail.ID)
            Return View(teamDetail)
        End Function

        ' GET: TeamDetails/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim teamDetail As TeamDetail = db.TeamDetails.Find(id)
            If IsNothing(teamDetail) Then
                Return HttpNotFound()
            End If
            Return View(teamDetail)
        End Function

        ' POST: TeamDetails/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim teamDetail As TeamDetail = db.TeamDetails.Find(id)
            db.TeamDetails.Remove(teamDetail)
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
