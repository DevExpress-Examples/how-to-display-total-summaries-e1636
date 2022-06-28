Imports DevExpress.Data
Imports DevExpress.Xpf.Grid
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Windows

Namespace DXGrid_DisplayTotals

    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.ItemsSource = AccountList.GetData()
        End Sub

        ' Define total summaries in code:
        Private Sub CreateTotalSummaries()
            Me.grid.TotalSummary.AddRange(New List(Of GridSummaryItem)() From {New GridSummaryItem() With {.SummaryType = SummaryItemType.Count, .Alignment = GridSummaryItemAlignment.Left, .DisplayFormat = "Total Users: {0}"}, New GridSummaryItem() With {.FieldName = "Age", .SummaryType = SummaryItemType.Min}, New GridSummaryItem() With {.FieldName = "Age", .SummaryType = SummaryItemType.Max}})
        End Sub
    End Class

    Public Class AccountList

        Public Shared Function GetData() As ObservableCollection(Of Account)
            Dim list As ObservableCollection(Of Account) = New ObservableCollection(Of Account)()
            list.Add(New Account() With {.UserName = "Nick White", .RegistrationDate = Date.Today, .Married = True, .Age = 42})
            list.Add(New Account() With {.UserName = "Jack Rodman", .RegistrationDate = New DateTime(2009, 5, 10), .Married = False, .Age = 30})
            list.Add(New Account() With {.UserName = "Sandra Sherry", .RegistrationDate = New DateTime(2008, 12, 22), .Married = False, .Age = 18})
            list.Add(New Account() With {.UserName = "Sabrina Vilk", .RegistrationDate = Date.Today, .Married = True, .Age = 24})
            list.Add(New Account() With {.UserName = "Mike Pearson", .RegistrationDate = New DateTime(2008, 10, 18), .Married = True, .Age = 37})
            Return list
        End Function
    End Class

    Public Class Account

        Public Property UserName As String

        Public Property RegistrationDate As Date

        Public Property Married As Boolean

        Public Property Age As Integer
    End Class
End Namespace
