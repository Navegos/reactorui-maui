// <auto-generated />
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using MauiReactor.Animations;
using MauiReactor.Shapes;
using MauiReactor.Internals;

#nullable enable
namespace MauiReactor;
public partial interface IGrid : ILayout
{
    object? RowSpacing { get; set; }

    object? ColumnSpacing { get; set; }
}

public partial class Grid<T> : Layout<T>, IGrid where T : Microsoft.Maui.Controls.Grid, new()
{
    public Grid()
    {
        GridStyles.Default?.Invoke(this);
    }

    public Grid(Action<T?> componentRefAction) : base(componentRefAction)
    {
        GridStyles.Default?.Invoke(this);
    }

    object? IGrid.RowSpacing { get; set; }

    object? IGrid.ColumnSpacing { get; set; }

    internal override void Reset()
    {
        base.Reset();
        var thisAsIGrid = (IGrid)this;
        thisAsIGrid.RowSpacing = null;
        thisAsIGrid.ColumnSpacing = null;
        OnReset();
    }

    partial void OnReset();
    protected override void OnUpdate()
    {
        OnBeginUpdate();
        Validate.EnsureNotNull(NativeControl);
        var thisAsIGrid = (IGrid)this;
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Grid.RowSpacingProperty, thisAsIGrid.RowSpacing);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Grid.ColumnSpacingProperty, thisAsIGrid.ColumnSpacing);
        base.OnUpdate();
        OnEndUpdate();
    }

    protected override void OnAnimate()
    {
        OnBeginAnimate();
        var thisAsIGrid = (IGrid)this;
        AnimateProperty(Microsoft.Maui.Controls.Grid.RowSpacingProperty, thisAsIGrid.RowSpacing);
        AnimateProperty(Microsoft.Maui.Controls.Grid.ColumnSpacingProperty, thisAsIGrid.ColumnSpacing);
        base.OnAnimate();
        OnEndAnimate();
    }

    partial void OnBeginUpdate();
    partial void OnEndUpdate();
    partial void OnBeginAnimate();
    partial void OnEndAnimate();
    protected override void OnThemeChanged()
    {
        if (ThemeKey != null && GridStyles.Themes.TryGetValue(ThemeKey, out var styleAction))
        {
            styleAction(this);
        }

        base.OnThemeChanged();
    }
}

public partial class Grid : Grid<Microsoft.Maui.Controls.Grid>
{
    public Grid()
    {
    }

    public Grid(Action<Microsoft.Maui.Controls.Grid?> componentRefAction) : base(componentRefAction)
    {
    }
}

public static partial class GridExtensions
{
    static object? SetRowSpacing(object grid, RxAnimation animation) => ((IGrid)grid).RowSpacing = ((RxDoubleAnimation)animation).CurrentValue();
    static object? SetColumnSpacing(object grid, RxAnimation animation) => ((IGrid)grid).ColumnSpacing = ((RxDoubleAnimation)animation).CurrentValue();
    public static T RowSpacing<T>(this T grid, double rowSpacing, RxDoubleAnimation? customAnimation = null)
        where T : IGrid
    {
        grid.RowSpacing = rowSpacing;
        grid.AppendAnimatable(Microsoft.Maui.Controls.Grid.RowSpacingProperty, customAnimation ?? new RxDoubleAnimation(rowSpacing), SetRowSpacing);
        return grid;
    }

    public static T RowSpacing<T>(this T grid, Func<double> rowSpacingFunc)
        where T : IGrid
    {
        grid.RowSpacing = new PropertyValue<double>(rowSpacingFunc);
        return grid;
    }

    public static T ColumnSpacing<T>(this T grid, double columnSpacing, RxDoubleAnimation? customAnimation = null)
        where T : IGrid
    {
        grid.ColumnSpacing = columnSpacing;
        grid.AppendAnimatable(Microsoft.Maui.Controls.Grid.ColumnSpacingProperty, customAnimation ?? new RxDoubleAnimation(columnSpacing), SetColumnSpacing);
        return grid;
    }

    public static T ColumnSpacing<T>(this T grid, Func<double> columnSpacingFunc)
        where T : IGrid
    {
        grid.ColumnSpacing = new PropertyValue<double>(columnSpacingFunc);
        return grid;
    }
}

public static partial class GridStyles
{
    public static Action<IGrid>? Default { get; set; }
    public static Dictionary<string, Action<IGrid>> Themes { get; } = [];
}