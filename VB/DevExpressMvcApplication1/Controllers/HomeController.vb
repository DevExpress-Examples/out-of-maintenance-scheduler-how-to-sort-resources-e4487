Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports DevExpress.XtraScheduler

Namespace DevExpressMvcApplication1.Views
    Public Class HomeController
        Inherits Controller

        Public Function Index() As ActionResult
            Return View(SchedulerDataHelper.DataObject)
        End Function

        Public Function SchedulerPartial() As ActionResult
            ViewBag.ResourcesSortType = If(Request.Params("ResourcesSortType") IsNot Nothing, Integer.Parse(Request.Params("ResourcesSortType")), CInt(ResourcesSortOrder.None))
            Return PartialView("SchedulerPartial", SchedulerDataHelper.DataObject)
        End Function
    End Class
End Namespace
