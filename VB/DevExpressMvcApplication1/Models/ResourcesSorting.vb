Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Public Class ResourceSortType
	Private privateID As Integer
	Public Property ID() As Integer
		Get
			Return privateID
		End Get
		Set(ByVal value As Integer)
			privateID = value
		End Set
	End Property
	Private privateType As String
	Public Property Type() As String
		Get
			Return privateType
		End Get
		Set(ByVal value As String)
			privateType = value
		End Set
	End Property
End Class

Public Enum ResourcesSortOrder
	None = 0
	Ascending = 1
	Descending = 2
	NOfAppointments = 3
End Enum

Public Class ResourcesSortingHelper
    Public Shared Function GetItems() As IEnumerable
        Return TryCast(New List(Of ResourceSortType)() From { _
            New ResourceSortType() With { _
                .ID = CInt(ResourcesSortOrder.None), _
                .Type = "None" _
            }, _
            New ResourceSortType() With { _
                .ID = CInt(ResourcesSortOrder.Ascending), _
                .Type = "A-Z Order" _
            }, _
            New ResourceSortType() With { _
                .ID = CInt(ResourcesSortOrder.Descending), _
                .Type = "Z-A Order" _
            }, _
            New ResourceSortType() With { _
                .ID = CInt(ResourcesSortOrder.NOfAppointments), _
                .Type = "N-Appointments" _
            } _
        }, IEnumerable)
    End Function
End Class