@ModelType IEnumerable(Of WebApplication2.College)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.CollegeName)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CollegeName)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.CollegeID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.CollegeID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.CollegeID })
        </td>
    </tr>
Next

</table>
