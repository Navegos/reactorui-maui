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
public partial interface IBorder : IView
{
    object? Padding { get; set; }

    object? Stroke { get; set; }

    object? StrokeThickness { get; set; }

    object? StrokeDashArray { get; set; }

    object? StrokeDashOffset { get; set; }

    object? StrokeLineCap { get; set; }

    object? StrokeLineJoin { get; set; }

    object? StrokeMiterLimit { get; set; }
}

public partial class Border<T> : View<T>, IBorder where T : Microsoft.Maui.Controls.Border, new()
{
    public Border()
    {
        BorderStyles.Default?.Invoke(this);
    }

    public Border(Action<T?> componentRefAction) : base(componentRefAction)
    {
        BorderStyles.Default?.Invoke(this);
    }

    object? IBorder.Padding { get; set; }

    object? IBorder.Stroke { get; set; }

    object? IBorder.StrokeThickness { get; set; }

    object? IBorder.StrokeDashArray { get; set; }

    object? IBorder.StrokeDashOffset { get; set; }

    object? IBorder.StrokeLineCap { get; set; }

    object? IBorder.StrokeLineJoin { get; set; }

    object? IBorder.StrokeMiterLimit { get; set; }

    internal override void Reset()
    {
        base.Reset();
        var thisAsIBorder = (IBorder)this;
        thisAsIBorder.Padding = null;
        thisAsIBorder.Stroke = null;
        thisAsIBorder.StrokeThickness = null;
        thisAsIBorder.StrokeDashArray = null;
        thisAsIBorder.StrokeDashOffset = null;
        thisAsIBorder.StrokeLineCap = null;
        thisAsIBorder.StrokeLineJoin = null;
        thisAsIBorder.StrokeMiterLimit = null;
        OnReset();
    }

    partial void OnReset();
    protected override void OnUpdate()
    {
        OnBeginUpdate();
        Validate.EnsureNotNull(NativeControl);
        var thisAsIBorder = (IBorder)this;
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Border.PaddingProperty, thisAsIBorder.Padding);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Border.StrokeProperty, thisAsIBorder.Stroke);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Border.StrokeThicknessProperty, thisAsIBorder.StrokeThickness);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Border.StrokeDashArrayProperty, thisAsIBorder.StrokeDashArray);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Border.StrokeDashOffsetProperty, thisAsIBorder.StrokeDashOffset);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Border.StrokeLineCapProperty, thisAsIBorder.StrokeLineCap);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Border.StrokeLineJoinProperty, thisAsIBorder.StrokeLineJoin);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Border.StrokeMiterLimitProperty, thisAsIBorder.StrokeMiterLimit);
        base.OnUpdate();
        OnEndUpdate();
    }

    protected override void OnAnimate()
    {
        OnBeginAnimate();
        var thisAsIBorder = (IBorder)this;
        AnimateProperty(Microsoft.Maui.Controls.Border.PaddingProperty, thisAsIBorder.Padding);
        AnimateProperty(Microsoft.Maui.Controls.Border.StrokeThicknessProperty, thisAsIBorder.StrokeThickness);
        AnimateProperty(Microsoft.Maui.Controls.Border.StrokeDashOffsetProperty, thisAsIBorder.StrokeDashOffset);
        AnimateProperty(Microsoft.Maui.Controls.Border.StrokeMiterLimitProperty, thisAsIBorder.StrokeMiterLimit);
        base.OnAnimate();
        OnEndAnimate();
    }

    partial void OnBeginUpdate();
    partial void OnEndUpdate();
    partial void OnBeginAnimate();
    partial void OnEndAnimate();
    protected override void OnThemeChanged()
    {
        if (ThemeKey != null && BorderStyles.Themes.TryGetValue(ThemeKey, out var styleAction))
        {
            styleAction(this);
        }

        base.OnThemeChanged();
    }
}

public partial class Border : Border<Microsoft.Maui.Controls.Border>
{
    public Border()
    {
    }

    public Border(Action<Microsoft.Maui.Controls.Border?> componentRefAction) : base(componentRefAction)
    {
    }
}

public static partial class BorderExtensions
{
    static object? SetPadding(object border, RxAnimation animation) => ((IBorder)border).Padding = ((RxThicknessAnimation)animation).CurrentValue();
    static object? SetStrokeThickness(object border, RxAnimation animation) => ((IBorder)border).StrokeThickness = ((RxDoubleAnimation)animation).CurrentValue();
    static object? SetStrokeDashOffset(object border, RxAnimation animation) => ((IBorder)border).StrokeDashOffset = ((RxDoubleAnimation)animation).CurrentValue();
    static object? SetStrokeMiterLimit(object border, RxAnimation animation) => ((IBorder)border).StrokeMiterLimit = ((RxDoubleAnimation)animation).CurrentValue();
    public static T Padding<T>(this T border, Microsoft.Maui.Thickness padding, RxThicknessAnimation? customAnimation = null)
        where T : IBorder
    {
        border.Padding = padding;
        border.AppendAnimatable(Microsoft.Maui.Controls.Border.PaddingProperty, customAnimation ?? new RxSimpleThicknessAnimation(padding), SetPadding);
        return border;
    }

    public static T Padding<T>(this T border, Func<Microsoft.Maui.Thickness> paddingFunc)
        where T : IBorder
    {
        border.Padding = new PropertyValue<Microsoft.Maui.Thickness>(paddingFunc);
        return border;
    }

    public static T Padding<T>(this T border, double leftRight, double topBottom, RxThicknessAnimation? customAnimation = null)
        where T : IBorder
    {
        border.Padding = new Thickness(leftRight, topBottom);
        border.AppendAnimatable(Microsoft.Maui.Controls.Border.PaddingProperty, customAnimation ?? new RxSimpleThicknessAnimation(new Thickness(leftRight, topBottom)), SetPadding);
        return border;
    }

    public static T Padding<T>(this T border, double uniformSize, RxThicknessAnimation? customAnimation = null)
        where T : IBorder
    {
        border.Padding = new Thickness(uniformSize);
        border.AppendAnimatable(Microsoft.Maui.Controls.Border.PaddingProperty, customAnimation ?? new RxSimpleThicknessAnimation(new Thickness(uniformSize)), SetPadding);
        return border;
    }

    public static T Padding<T>(this T border, double left, double top, double right, double bottom, RxThicknessAnimation? customAnimation = null)
        where T : IBorder
    {
        border.Padding = new Thickness(left, top, right, bottom);
        border.AppendAnimatable(Microsoft.Maui.Controls.Border.PaddingProperty, customAnimation ?? new RxSimpleThicknessAnimation(new Thickness(left, top, right, bottom)), SetPadding);
        return border;
    }

    public static T Stroke<T>(this T border, Microsoft.Maui.Controls.Brush stroke)
        where T : IBorder
    {
        border.Stroke = stroke;
        return border;
    }

    public static T Stroke<T>(this T border, Func<Microsoft.Maui.Controls.Brush> strokeFunc)
        where T : IBorder
    {
        border.Stroke = new PropertyValue<Microsoft.Maui.Controls.Brush>(strokeFunc);
        return border;
    }

    public static T StrokeThickness<T>(this T border, double strokeThickness, RxDoubleAnimation? customAnimation = null)
        where T : IBorder
    {
        border.StrokeThickness = strokeThickness;
        border.AppendAnimatable(Microsoft.Maui.Controls.Border.StrokeThicknessProperty, customAnimation ?? new RxDoubleAnimation(strokeThickness), SetStrokeThickness);
        return border;
    }

    public static T StrokeThickness<T>(this T border, Func<double> strokeThicknessFunc)
        where T : IBorder
    {
        border.StrokeThickness = new PropertyValue<double>(strokeThicknessFunc);
        return border;
    }

    public static T StrokeDashArray<T>(this T border, Microsoft.Maui.Controls.DoubleCollection strokeDashArray)
        where T : IBorder
    {
        border.StrokeDashArray = strokeDashArray;
        return border;
    }

    public static T StrokeDashArray<T>(this T border, Func<Microsoft.Maui.Controls.DoubleCollection> strokeDashArrayFunc)
        where T : IBorder
    {
        border.StrokeDashArray = new PropertyValue<Microsoft.Maui.Controls.DoubleCollection>(strokeDashArrayFunc);
        return border;
    }

    public static T StrokeDashOffset<T>(this T border, double strokeDashOffset, RxDoubleAnimation? customAnimation = null)
        where T : IBorder
    {
        border.StrokeDashOffset = strokeDashOffset;
        border.AppendAnimatable(Microsoft.Maui.Controls.Border.StrokeDashOffsetProperty, customAnimation ?? new RxDoubleAnimation(strokeDashOffset), SetStrokeDashOffset);
        return border;
    }

    public static T StrokeDashOffset<T>(this T border, Func<double> strokeDashOffsetFunc)
        where T : IBorder
    {
        border.StrokeDashOffset = new PropertyValue<double>(strokeDashOffsetFunc);
        return border;
    }

    public static T StrokeLineCap<T>(this T border, Microsoft.Maui.Controls.Shapes.PenLineCap strokeLineCap)
        where T : IBorder
    {
        border.StrokeLineCap = strokeLineCap;
        return border;
    }

    public static T StrokeLineCap<T>(this T border, Func<Microsoft.Maui.Controls.Shapes.PenLineCap> strokeLineCapFunc)
        where T : IBorder
    {
        border.StrokeLineCap = new PropertyValue<Microsoft.Maui.Controls.Shapes.PenLineCap>(strokeLineCapFunc);
        return border;
    }

    public static T StrokeLineJoin<T>(this T border, Microsoft.Maui.Controls.Shapes.PenLineJoin strokeLineJoin)
        where T : IBorder
    {
        border.StrokeLineJoin = strokeLineJoin;
        return border;
    }

    public static T StrokeLineJoin<T>(this T border, Func<Microsoft.Maui.Controls.Shapes.PenLineJoin> strokeLineJoinFunc)
        where T : IBorder
    {
        border.StrokeLineJoin = new PropertyValue<Microsoft.Maui.Controls.Shapes.PenLineJoin>(strokeLineJoinFunc);
        return border;
    }

    public static T StrokeMiterLimit<T>(this T border, double strokeMiterLimit, RxDoubleAnimation? customAnimation = null)
        where T : IBorder
    {
        border.StrokeMiterLimit = strokeMiterLimit;
        border.AppendAnimatable(Microsoft.Maui.Controls.Border.StrokeMiterLimitProperty, customAnimation ?? new RxDoubleAnimation(strokeMiterLimit), SetStrokeMiterLimit);
        return border;
    }

    public static T StrokeMiterLimit<T>(this T border, Func<double> strokeMiterLimitFunc)
        where T : IBorder
    {
        border.StrokeMiterLimit = new PropertyValue<double>(strokeMiterLimitFunc);
        return border;
    }
}

public static partial class BorderStyles
{
    public static Action<IBorder>? Default { get; set; }
    public static Dictionary<string, Action<IBorder>> Themes { get; } = [];
}