@Code
    ViewData("Title") = "Home Page"
End Code

<div class="jumbotron">
    <h1>ASP.NET</h1>
    <p class="lead">ASP.NET MVC architecture with SQL server</p>
</div>

<div class="row">
    <div class="col-md-4">
        <h2>@Html.ActionLink("TeamDetails", "Index", "TeamDetails")</h2>
        <p>MVC CRUDD operations</p>
    </div>
    <div class="col-md-4">
        <h2>@Html.ActionLink("Players", "Index", "Players")</h2>
        <p>MVC CRUDD operations</p>
    </div>

</div>
