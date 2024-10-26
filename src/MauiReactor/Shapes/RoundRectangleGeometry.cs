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
namespace MauiReactor.Shapes;
public partial interface IRoundRectangleGeometry : Shapes.IGeometryGroup
{
    object? Rect { get; set; }

    object? CornerRadius { get; set; }
}

public partial class RoundRectangleGeometry<T> : Shapes.GeometryGroup<T>, IRoundRectangleGeometry where T : Microsoft.Maui.Controls.Shapes.RoundRectangleGeometry, new()
{
    public RoundRectangleGeometry()
    {
        RoundRectangleGeometryStyles.Default?.Invoke(this);
    }

    public RoundRectangleGeometry(Action<T?> componentRefAction) : base(componentRefAction)
    {
        RoundRectangleGeometryStyles.Default?.Invoke(this);
    }

    object? IRoundRectangleGeometry.Rect { get; set; }

    object? IRoundRectangleGeometry.CornerRadius { get; set; }

    internal override void Reset()
    {
        base.Reset();
        var thisAsIRoundRectangleGeometry = (IRoundRectangleGeometry)this;
        thisAsIRoundRectangleGeometry.Rect = null;
        thisAsIRoundRectangleGeometry.CornerRadius = null;
        OnReset();
    }

    partial void OnReset();
    protected override void OnUpdate()
    {
        OnBeginUpdate();
        Validate.EnsureNotNull(NativeControl);
        var thisAsIRoundRectangleGeometry = (IRoundRectangleGeometry)this;
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shapes.RoundRectangleGeometry.RectProperty, thisAsIRoundRectangleGeometry.Rect);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shapes.RoundRectangleGeometry.CornerRadiusProperty, thisAsIRoundRectangleGeometry.CornerRadius);
        base.OnUpdate();
        OnEndUpdate();
    }

    protected override void OnAnimate()
    {
        OnBeginAnimate();
        var thisAsIRoundRectangleGeometry = (IRoundRectangleGeometry)this;
        AnimateProperty(Microsoft.Maui.Controls.Shapes.RoundRectangleGeometry.RectProperty, thisAsIRoundRectangleGeometry.Rect);
        AnimateProperty(Microsoft.Maui.Controls.Shapes.RoundRectangleGeometry.CornerRadiusProperty, thisAsIRoundRectangleGeometry.CornerRadius);
        base.OnAnimate();
        OnEndAnimate();
    }

    partial void OnBeginUpdate();
    partial void OnEndUpdate();
    partial void OnBeginAnimate();
    partial void OnEndAnimate();
    protected override void OnThemeChanged()
    {
        if (ThemeKey != null && RoundRectangleGeometryStyles.Themes.TryGetValue(ThemeKey, out var styleAction))
        {
            styleAction(this);
        }

        base.OnThemeChanged();
    }
}

public partial class RoundRectangleGeometry : RoundRectangleGeometry<Microsoft.Maui.Controls.Shapes.RoundRectangleGeometry>
{
    public RoundRectangleGeometry()
    {
    }

    public RoundRectangleGeometry(Action<Microsoft.Maui.Controls.Shapes.RoundRectangleGeometry?> componentRefAction) : base(componentRefAction)
    {
    }
}

public static partial class RoundRectangleGeometryExtensions
{
    static object? SetRect(object roundRectangleGeometry, RxAnimation animation) => ((IRoundRectangleGeometry)roundRectangleGeometry).Rect = ((RxRectAnimation)animation).CurrentValue();
    static object? SetCornerRadius(object roundRectangleGeometry, RxAnimation animation) => ((IRoundRectangleGeometry)roundRectangleGeometry).CornerRadius = ((RxCornerRadiusAnimation)animation).CurrentValue();
    public static T Rect<T>(this T roundRectangleGeometry, Microsoft.Maui.Graphics.Rect rect, RxRectAnimation? customAnimation = null)
        where T : IRoundRectangleGeometry
    {
        roundRectangleGeometry.Rect = rect;
        roundRectangleGeometry.AppendAnimatable(Microsoft.Maui.Controls.Shapes.RoundRectangleGeometry.RectProperty, customAnimation ?? new RxSimpleRectAnimation(rect), SetRect);
        return roundRectangleGeometry;
    }

    public static T Rect<T>(this T roundRectangleGeometry, Func<Microsoft.Maui.Graphics.Rect> rectFunc)
        where T : IRoundRectangleGeometry
    {
        roundRectangleGeometry.Rect = new PropertyValue<Microsoft.Maui.Graphics.Rect>(rectFunc);
        return roundRectangleGeometry;
    }

    public static T CornerRadius<T>(this T roundRectangleGeometry, Microsoft.Maui.CornerRadius cornerRadius, RxCornerRadiusAnimation? customAnimation = null)
        where T : IRoundRectangleGeometry
    {
        roundRectangleGeometry.CornerRadius = cornerRadius;
        roundRectangleGeometry.AppendAnimatable(Microsoft.Maui.Controls.Shapes.RoundRectangleGeometry.CornerRadiusProperty, customAnimation ?? new RxSimpleCornerRadiusAnimation(cornerRadius), SetCornerRadius);
        return roundRectangleGeometry;
    }

    public static T CornerRadius<T>(this T roundRectangleGeometry, Func<Microsoft.Maui.CornerRadius> cornerRadiusFunc)
        where T : IRoundRectangleGeometry
    {
        roundRectangleGeometry.CornerRadius = new PropertyValue<Microsoft.Maui.CornerRadius>(cornerRadiusFunc);
        return roundRectangleGeometry;
    }

    public static T CornerRadius<T>(this T roundRectangleGeometry, double uniformRadius, RxCornerRadiusAnimation? customAnimation = null)
        where T : IRoundRectangleGeometry
    {
        roundRectangleGeometry.CornerRadius = new CornerRadius(uniformRadius);
        roundRectangleGeometry.AppendAnimatable(Microsoft.Maui.Controls.Shapes.RoundRectangleGeometry.CornerRadiusProperty, customAnimation ?? new RxSimpleCornerRadiusAnimation(new CornerRadius(uniformRadius)), SetCornerRadius);
        return roundRectangleGeometry;
    }

    public static T CornerRadius<T>(this T roundRectangleGeometry, double topLeft, double topRight, double bottomLeft, double bottomRight, RxCornerRadiusAnimation? customAnimation = null)
        where T : IRoundRectangleGeometry
    {
        roundRectangleGeometry.CornerRadius = new CornerRadius(topLeft, topRight, bottomLeft, bottomRight);
        roundRectangleGeometry.AppendAnimatable(Microsoft.Maui.Controls.Shapes.RoundRectangleGeometry.CornerRadiusProperty, customAnimation ?? new RxSimpleCornerRadiusAnimation(new CornerRadius(topLeft, topRight, bottomLeft, bottomRight)), SetCornerRadius);
        return roundRectangleGeometry;
    }
}

public static partial class RoundRectangleGeometryStyles
{
    public static Action<IRoundRectangleGeometry>? Default { get; set; }
    public static Dictionary<string, Action<IRoundRectangleGeometry>> Themes { get; } = [];
}