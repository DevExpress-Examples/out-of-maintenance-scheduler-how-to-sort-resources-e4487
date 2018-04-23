Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports DevExpress.Web.Mvc
Imports DevExpress.XtraScheduler

Public MustInherit Class ResourceBaseComparer
    Implements IComparer(Of Resource), IComparer

    #Region "IComparer Members"
    Private Function IComparer_Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
        Return CompareCore(x, y)
    End Function
    Public Function Compare(ByVal x As Resource, ByVal y As Resource) As Integer Implements IComparer(Of Resource).Compare
        Return CompareCore(x, y)
    End Function
    #End Region

    Protected Overridable Function CompareCore(ByVal x As Object, ByVal y As Object) As Integer
        Dim xRes As Resource = DirectCast(x, Resource)
        Dim yRes As Resource = DirectCast(y, Resource)

        If xRes Is Nothing OrElse yRes Is Nothing Then
            Return 0
        End If
        If ResourceEmpty.Resource.Equals(xRes) OrElse ResourceEmpty.Resource.Equals(yRes) Then
            Return 0
        End If

        Return CompareResources(xRes, yRes)
    End Function

    Protected MustOverride Function CompareResources(ByVal xRes As Resource, ByVal yRes As Resource) As Integer
End Class

Public Class ResourceCaptionComparer
    Inherits ResourceBaseComparer

    Protected Overrides Function CompareResources(ByVal xRes As Resource, ByVal yRes As Resource) As Integer
        Return String.Compare(xRes.Caption, yRes.Caption)
    End Function
End Class

Public Class ResourceCaptionReverseComparer
    Inherits ResourceBaseComparer

    Protected Overrides Function CompareResources(ByVal xRes As Resource, ByVal yRes As Resource) As Integer
        Return String.Compare(yRes.Caption, xRes.Caption)
    End Function
End Class

Public Class ResourceNOfAppointmentsComparer
    Inherits ResourceBaseComparer

    Private schedulerStorage As MVCxSchedulerStorage

    Public Sub New(ByVal schedulerStorage As MVCxSchedulerStorage)
        Me.schedulerStorage = schedulerStorage
    End Sub

    Protected Overrides Function CompareResources(ByVal xRes As Resource, ByVal yRes As Resource) As Integer
        Dim order As Integer = schedulerStorage.Appointments.Items.FindAll(Function(e) e.ResourceId.Equals(yRes.Id)).Count - schedulerStorage.Appointments.Items.FindAll(Function(e) e.ResourceId.Equals(xRes.Id)).Count

        Return If(order <> 0, order, schedulerStorage.Resources.Items.IndexOf(xRes) - schedulerStorage.Resources.Items.IndexOf(yRes))
    End Function
End Class