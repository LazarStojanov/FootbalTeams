@ModelType FootbalTeams.Player
@Code
    ViewData("Title") = "Delete"
   @* Layout = "~/Views/_ViewStart.vbhtml" *@
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
