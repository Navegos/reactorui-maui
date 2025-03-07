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
public partial interface IEllipse : Shapes.IShape
{
}

public sealed partial class Ellipse : Shapes.Shape<Microsoft.Maui.Controls.Shapes.Ellipse>, IEllipse
{
    public Ellipse(Action<Microsoft.Maui.Controls.Shapes.Ellipse?>? componentRefAction = null) : base(componentRefAction)
    {
        EllipseStyles.Default?.Invoke(this);
    }

    partial void OnBeginAnimate();
    partial void OnEndAnimate();
    protected override void OnThemeChanged()
    {
        if (ThemeKey != null && EllipseStyles.Themes.TryGetValue(ThemeKey, out var styleAction))
        {
            styleAction(this);
        }

        base.OnThemeChanged();
    }

    partial void Migrated(VisualNode newNode);
    protected override void OnMigrated(VisualNode newNode)
    {
        Migrated(newNode);
        base.OnMigrated(newNode);
    }
}

public static partial class EllipseExtensions
{
}

public static partial class EllipseStyles
{
    public static Action<IEllipse>? Default { get; set; }
    public static Dictionary<string, Action<IEllipse>> Themes { get; } = [];
}