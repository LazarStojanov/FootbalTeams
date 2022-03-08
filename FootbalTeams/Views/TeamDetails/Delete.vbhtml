﻿@ModelType FootbalTeams.TeamDetail
@Code
    ViewData("Title") = "Delete"
   @* Layout = "~/Views/_ViewStart.vbhtml" *@
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
