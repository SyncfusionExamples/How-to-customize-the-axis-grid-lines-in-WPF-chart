# How-to-customize-the-axis-grid-lines-in-WPF-chart
This sample demonstrate how to customize the axis grid lines in WPF chart.

The [WPF Chart](https://www.syncfusion.com/wpf-controls/charts) provides support to customize the axis grid lines with the help of the [MajorGridLineStyle](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ChartAxis.html#Syncfusion_UI_Xaml_Charts_ChartAxis_MajorGridLineStyle), [MinorGridLineStyle](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ChartAxis.html#Syncfusion_UI_Xaml_Charts_ChartAxis_MinorGridLineStyle), [MajorTickLineStyle](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ChartAxis.html#Syncfusion_UI_Xaml_Charts_ChartAxis_MajorTickLineStyle), and [MinorTickLineStyle](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ChartAxis.html#Syncfusion_UI_Xaml_Charts_ChartAxis_MinorTickLineStyle) properties of the chart axis.

These properties are of type "Style," which means you can customize the axis grid lines by changing the value of line properties such as Stroke, StrokeThickness, and StrokeDashArray. 

For example, you can set the stroke color of the major grid lines to green and the stroke thickness to 2, like this:

**[XAML]**

```
<chart:NumericalAxis>
    <chart:NumericalAxis.MajorGridLineStyle>
        <Style TargetType="Line">
            <Setter Property="StrokeThickness" Value="2"/>
            <Setter Property="Stroke" Value="Green"/>
        </Style>
    </chart:NumericalAxis.MajorGridLineStyle>
</chart:NumericalAxis>

```
You can also use the StrokeDashArray property to set the line style to a dashed pattern like this:

**[XAML]**

```
<chart:NumericalAxis>
    <chart:NumericalAxis.MinorGridLineStyle>
        <Style TargetType="Line">
            <Setter Property="StrokeThickness" Value="1"/>
            <Setter Property="Stroke" Value="Blue"/>
            <Setter Property="StrokeDashArray" Value="3,3"/>
        </Style>
    </chart:NumericalAxis.MinorGridLineStyle>
</chart:NumericalAxis>

```

## Output:
![Customize the axis grid lines in WPF Chart](https://user-images.githubusercontent.com/61832185/213699174-b38a6998-c7b1-4df6-a788-348020dfa9e4.png)

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
