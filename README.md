# How to Add Icon on Specific Row Header of WPF DataGrid?

This sample illustrated that how to add icon on specific row header of [WPF DataGrid](https://www.syncfusion.com/wpf-controls/datagrid) (SfDataGrid).

The `DataGrid` does not provide the direct support to add an image in RowHeader cells. But you can add an image in the RowHeader cell by customizing the [Syncfusion:GridRowHeaderCell](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.GridRowHeaderCell.html).

#### XAML

```xml
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

#### C#

```C#
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
![DataGrid with icon added to the specifc row header](RowHeaderWithIcon.png)