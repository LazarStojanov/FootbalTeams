@ModelType FootbalTeams.TeamDetail
@Code
    ViewData("Title") = "Details"
   @* Layout = "~/Views/_ViewStart.vbhtml" *@
End Code

<h2>Details</h2>

<div>
    <h4>TeamDetail</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.City)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.City)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Stadium)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Stadium)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.YearOfCreating)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.YearOfCreating)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.History)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.History)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Player.FirstName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Player.FirstName)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With {.id = Model.ID}) |
    @Html.ActionLink("Back to List", "Index")
</p>
