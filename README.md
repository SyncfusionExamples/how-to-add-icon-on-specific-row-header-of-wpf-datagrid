# how-to-add-icon-on-specific-row-header-of-wpf-datagrid
How to add icon on specific row header of WPF DataGrid(SfDataGrid)?

By default, the SfDataGrid does not have add any image in RowHeader cells. However, an image can be added in the RowHeader cell by adding an external property for Syncfusion:GridRowHeaderCell to bind the image with RowHeader cell.

```
<Window.Resources>
    <local:RowHeaderConverter x:Key="rowHeaderConverter"/>
    <Style TargetType="syncfusion:GridRowHeaderCell">
        <Setter Property="Template">
            <Setter.Value>
                <ControlTemplate TargetType="syncfusion:GridRowHeaderCell">
                    <Border x:Name="PART_RowHeaderCellBorder"
                    BorderBrush="{TemplateBinding BorderBrush}"
                    BorderThickness="{TemplateBinding BorderThickness}">
                        <Grid>
                            <Image  Source="{Binding IsLocked, Converter={StaticResource rowHeaderConverter}}" />
                        </Grid>
                    </Border>
                </ControlTemplate>                   
            </Setter.Value>
        </Setter>
    </Style>
</Window.Resources>
```

```
foreach(var record in datagrid.View.Records)
{
    var data = (record as RecordEntry).Data as OrderInfo;
    if (data.OrderID % 3 == 0)
    {
        //To change the image at run time.
        data.IsLocked = true;
    }
}
```
![IconForRowHeader](IconForRowHeader.png)
