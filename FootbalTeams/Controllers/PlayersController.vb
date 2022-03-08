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
    Public Class PlayersController
        Inherits System.Web.Mvc.Controller

        Private db As New FootballTeamsEntities

        ' GET: Players
        Function Index() As ActionResult
            Dim players = db.Players.Include(Function(p) p.TeamDetail)
            Return View(players.ToList())
        End Function

        ' GET: Players/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim player As Player = db.Players.Find(id)
            If IsNothing(player) Then
                Return HttpNotFound()
            End If
            Return View(player)
        End Function

        ' GET: Players/Create
        Function Create() As ActionResult
            ViewBag.PlayerID = New SelectList(db.TeamDetails, "ID", "Name")
            Return View()
        End Function

        ' POST: Players/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="PlayerID,FirstName,LastName,DateOfBirth,Value")> ByVal player As Player) As ActionResult
            If ModelState.IsValid Then
                db.Players.Add(player)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.PlayerID = New SelectList(db.TeamDetails, "ID", "Name", player.PlayerID)
            Return View(player)
        End Function

        ' GET: Players/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim player As Player = db.Players.Find(id)
            If IsNothing(player) Then
                Return HttpNotFound()
            End If
            ViewBag.PlayerID = New SelectList(db.TeamDetails, "ID", "Name", player.PlayerID)
            Return View(player)
        End Function

        ' POST: Players/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="PlayerID,FirstName,LastName,DateOfBirth,Value")> ByVal player As Player) As ActionResult
            If ModelState.IsValid Then
                db.Entry(player).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.PlayerID = New SelectList(db.TeamDetails, "ID", "Name", player.PlayerID)
            Return View(player)
        End Function

        ' GET: Players/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim player As Player = db.Players.Find(id)
            If IsNothing(player) Then
                Return HttpNotFound()
            End If
            Return View(player)
        End Function

        ' POST: Players/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim player As Player = db.Players.Find(id)
            db.Players.Remove(player)
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
