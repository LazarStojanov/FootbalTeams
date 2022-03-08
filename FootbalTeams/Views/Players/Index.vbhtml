@ModelType IEnumerable(Of FootbalTeams.Player)
@Code
    ViewData("Title") = "Index"
   @* Layout = "~/Views/_ViewStart.vbhtml" *@
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.FirstName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.LastName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DateOfBirth)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Value)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TeamDetail.Name)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.FirstName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.LastName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DateOfBirth)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Value)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TeamDetail.Name)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.PlayerID}) |
            @Html.ActionLink("Details", "Details", New With {.id = item.PlayerID}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.PlayerID})
        </td>
    </tr>
Next

</table>
