@ModelType SchedulerDataObject
@Code 
    ViewBag.Title = "Home Page"
End Code

@Html.Partial("ResourcesSortTypePartial")
@Html.Partial("SchedulerPartial", Model)