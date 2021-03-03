# How to change the fontsize for header with ColumnSizer as SizeToHeader in WPF DataGrid (SfDataGrid) ?

How to change the fontsize for header with ColumnSizer as SizeToHeader in WPF DataGrid (SfDataGrid) ?

# About the sample

By default, [WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfDataGrid) HeaderText Width is calculated with static FontSize even you changed the GridHeaderCellControl FontSize using HeaderStyle. You can achieve this by overriding GetFormattedText method in SfDataGrid.ColumnSizer class.

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

## Requirements to run the demo
 Visual Studio 2015 and above versions
