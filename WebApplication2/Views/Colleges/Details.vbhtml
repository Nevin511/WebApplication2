@ModelType WebApplication2.College
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>College</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.CollegeName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CollegeName)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.CollegeID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
