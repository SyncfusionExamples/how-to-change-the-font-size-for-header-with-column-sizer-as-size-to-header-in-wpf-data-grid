# How to change the fontsize for header with ColumnSizer as SizeToHeader in WPF DataGrid (SfDataGrid) ?

This sample show cases how to change the fontsize for header with ColumnSizer as SizeToHeader in [WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfDataGrid) ?

# About the sample

The header text width is calculated with static font size in [WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfDataGrid) and you can change the header font size using [HeaderStyle](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.SfDataGrid.html#Syncfusion_UI_Xaml_Grid_SfDataGrid_HeaderStyle) property. You can achieve this by overriding GetFormattedText method in [SfDataGrid.ColumnSizer](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.SfDataGrid.html#Syncfusion_UI_Xaml_Grid_SfDataGrid_ColumnSizer) class.

```c#
public class GridColumnSizerExt : GridColumnSizer
{

    public GridColumnSizerExt(SfDataGrid dataGrid)
        : base(dataGrid)
    {

    }

    protected override FormattedText GetFormattedText(GridColumn column, object record, string displayText)
    {
        var formattedText = base.GetFormattedText(column, record, displayText);

        if (record == null)
        {
            formattedText.SetFontSize(16);
        }
        return formattedText;
    }
}
```

KB article - [How to change the fontsize for header with ColumnSizer as SizeToHeader in WPF DataGrid (SfDataGrid)?](https://www.syncfusion.com/kb/12132/how-to-change-the-font-size-for-header-with-columnsizer-as-sizetoheader-in-wpf-datagrid)

## Requirements to run the demo
 Visual Studio 2015 and above versions
