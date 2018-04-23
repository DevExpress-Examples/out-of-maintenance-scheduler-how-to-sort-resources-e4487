<table>
    <tr>
        <td>
            @Html.DevExpress().Label( _
                Sub(settings)
                        settings.Name = "ResourcesSortTypeLabel"
                        settings.Width = System.Web.UI.WebControls.Unit.Pixel(150)
                        settings.Text = "Resources Sort Type: "
                End Sub).GetHtml()
        </td>
        <td>
            @Html.DevExpress().ComboBox( _
               Sub(settings)
                       settings.Name = "ResourcesSortType"
                       settings.Width = System.Web.UI.WebControls.Unit.Pixel(300)
                       settings.Properties.TextField = "Type"
                       settings.Properties.ValueField = "ID"
                       settings.Properties.ValueType = GetType(Integer)
                       settings.SelectedIndex = 0
                       settings.Properties.ClientSideEvents.SelectedIndexChanged = "function(s, e) { scheduler.PerformCallback(); }"
               End Sub).BindList(ResourcesSortingHelper.GetItems()).GetHtml()
        </td>
    </tr>
</table>
