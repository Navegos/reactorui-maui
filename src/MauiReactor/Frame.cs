// <auto-generated />
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using MauiReactor.Animations;
using MauiReactor.Shapes;
using MauiReactor.Internals;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable
namespace MauiReactor;
public partial interface IFrame : IContentView
{
    object? BorderColor { get; set; }

    object? HasShadow { get; set; }

    object? CornerRadius { get; set; }
}

public partial class Frame<T> : ContentView<T>, IFrame where T : Microsoft.Maui.Controls.Frame, new()
{
    public Frame()
    {
        FrameStyles.Default?.Invoke(this);
    }

    public Frame(Action<T?> componentRefAction) : base(componentRefAction)
    {
        FrameStyles.Default?.Invoke(this);
    }

    object? IFrame.BorderColor { get; set; }

    object? IFrame.HasShadow { get; set; }

    object? IFrame.CornerRadius { get; set; }

    internal override void Reset()
    {
        base.Reset();
        var thisAsIFrame = (IFrame)this;
        thisAsIFrame.BorderColor = null;
        thisAsIFrame.HasShadow = null;
        thisAsIFrame.CornerRadius = null;
        OnReset();
    }

    partial void OnReset();
    protected override void OnUpdate()
    {
        OnBeginUpdate();
        Validate.EnsureNotNull(NativeControl);
        var thisAsIFrame = (IFrame)this;
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Frame.BorderColorProperty, thisAsIFrame.BorderColor);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Frame.HasShadowProperty, thisAsIFrame.HasShadow);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Frame.CornerRadiusProperty, thisAsIFrame.CornerRadius);
        base.OnUpdate();
        OnEndUpdate();
    }

    partial void OnBeginUpdate();
    partial void OnEndUpdate();
    partial void OnBeginAnimate();
    partial void OnEndAnimate();
    protected override void OnThemeChanged()
    {
        if (ThemeKey != null && FrameStyles.Themes.TryGetValue(ThemeKey, out var styleAction))
        {
            styleAction(this);
        }

        base.OnThemeChanged();
    }
}

public partial class Frame : Frame<Microsoft.Maui.Controls.Frame>
{
    public Frame()
    {
    }

    public Frame(Action<Microsoft.Maui.Controls.Frame?> componentRefAction) : base(componentRefAction)
    {
    }
}

public static partial class FrameExtensions
{
    public static T BorderColor<T>(this T frame, Microsoft.Maui.Graphics.Color borderColor)
        where T : IFrame
    {
        frame.BorderColor = borderColor;
        return frame;
    }

    public static T BorderColor<T>(this T frame, Func<Microsoft.Maui.Graphics.Color> borderColorFunc)
        where T : IFrame
    {
        frame.BorderColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(borderColorFunc);
        return frame;
    }

    public static T HasShadow<T>(this T frame, bool hasShadow)
        where T : IFrame
    {
        frame.HasShadow = hasShadow;
        return frame;
    }

    public static T HasShadow<T>(this T frame, Func<bool> hasShadowFunc)
        where T : IFrame
    {
        frame.HasShadow = new PropertyValue<bool>(hasShadowFunc);
        return frame;
    }

    public static T CornerRadius<T>(this T frame, float cornerRadius)
        where T : IFrame
    {
        frame.CornerRadius = cornerRadius;
        return frame;
    }

    public static T CornerRadius<T>(this T frame, Func<float> cornerRadiusFunc)
        where T : IFrame
    {
        frame.CornerRadius = new PropertyValue<float>(cornerRadiusFunc);
        return frame;
    }
}

public static partial class FrameStyles
{
    public static Action<IFrame>? Default { get; set; }
    public static Dictionary<string, Action<IFrame>> Themes { get; } = [];
}

#pragma warning restore CS0618 // Type or member is obsolete
