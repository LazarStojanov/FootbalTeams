@ModelType FootbalTeams.Player
@Code
    ViewData("Title") = "Details"
   @* Layout = "~/Views/_ViewStart.vbhtml" *@
End Code

<h2>Details</h2>

<div>
    <h4>Player</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.FirstName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.FirstName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.LastName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.LastName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DateOfBirth)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DateOfBirth)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Value)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Value)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TeamDetail.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TeamDetail.Name)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With {.id = Model.PlayerID}) |
    @Html.ActionLink("Back to List", "Index")
</p>
