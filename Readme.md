<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128650079/22.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1636)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# WPF Data Grid - Display Total Summaries

This example displays total summaries specified in XAML and demonstrates how to define summaries in code.

![image](https://user-images.githubusercontent.com/65009440/176139290-69dafaf1-3c4c-4ef5-ae7b-5d732d988973.png)

1. Create a [GridSummaryItem](http://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridSummaryItem) object and specify its properties.
2. Add this object to the [GridControl.TotalSummary](http://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl.TotalSummary) collection.
3. Specify the [DataViewBase.TotalSummaryPosition](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataViewBase.TotalSummaryPosition?v=22.2) property to display the [Summary Panel](http://docs.devexpress.com/WPF/6259/controls-and-libraries/data-grid/visual-elements/common-elements/summary-panel). For the [Fixed Summary Panel](http://docs.devexpress.com/WPF/11404/controls-and-libraries/data-grid/visual-elements/common-elements/fixed-summary-panel), use the [DataViewBase.ShowFixedTotalSummary](http://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataViewBase.ShowFixedTotalSummary) property.

## Files to look at

* [Window1.xaml](./CS/DXGrid_DisplayTotals/Window1.xaml) (VB: [Window1.xaml](./VB/DXGrid_DisplayTotals/Window1.xaml))
* [Window1.xaml.cs](./CS/DXGrid_DisplayTotals/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/DXGrid_DisplayTotals/Window1.xaml.vb))

## Documentation

* [Total Summary](http://docs.devexpress.com/WPF/6128/controls-and-libraries/data-grid/data-summaries/total-summary)
* [GridControl.TotalSummary](http://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl.TotalSummary)
* [Data Summaries](http://docs.devexpress.com/WPF/7354/controls-and-libraries/data-grid/data-summaries)
* [Bind the Grid to Total and Group Summaries Specified in ViewModel](http://docs.devexpress.com/WPF/10124/controls-and-libraries/data-grid/examples/mvvm-enhancements/binding-to-total-and-group-summaries)

## More Examples

* [WPF Data Grid - How to Display Group Summaries](https://github.com/DevExpress-Examples/how-to-display-group-summaries-e1637)
* [WPF Data Grid - How to Use Custom Summaries](https://github.com/DevExpress-Examples/how-to-summarize-empty-cells-e948)
* [Bind the WPF GridControl to Total and Group Summaries Specified in ViewModel](https://github.com/DevExpress-Examples/wpf-mvvm-how-to-bind-the-gridcontrol-to-total-and-group-summaries-specified-in-viewmodel)
