@ModelType IEnumerable(Of FootbalTeams.TeamDetail)
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
            @Html.DisplayNameFor(Function(model) model.Name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.City)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Stadium)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.YearOfCreating)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.History)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Player.FirstName)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.City)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Stadium)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.YearOfCreating)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.History)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Player.FirstName)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.ID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.ID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.ID })
        </td>
    </tr>
Next

</table>
