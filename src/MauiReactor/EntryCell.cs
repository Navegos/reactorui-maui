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
public partial interface IEntryCell : ICell
{
    EventCommand<EventArgs>? CompletedEvent { get; set; }
}

public partial class EntryCell<T> : Cell<T>, IEntryCell where T : Microsoft.Maui.Controls.EntryCell, new()
{
    public EntryCell()
    {
        EntryCellStyles.Default?.Invoke(this);
    }

    public EntryCell(Action<T?> componentRefAction) : base(componentRefAction)
    {
        EntryCellStyles.Default?.Invoke(this);
    }

    EventCommand<EventArgs>? IEntryCell.CompletedEvent { get; set; }

    partial void OnBeginAnimate();
    partial void OnEndAnimate();
    protected override void OnThemeChanged()
    {
        if (ThemeKey != null && EntryCellStyles.Themes.TryGetValue(ThemeKey, out var styleAction))
        {
            styleAction(this);
        }

        base.OnThemeChanged();
    }

    partial void OnAttachingNativeEvents();
    partial void OnDetachingNativeEvents();
    private EventCommand<EventArgs>? _executingCompletedEvent;
    protected override void OnAttachNativeEvents()
    {
        Validate.EnsureNotNull(NativeControl);
        var thisAsIEntryCell = (IEntryCell)this;
        if (thisAsIEntryCell.CompletedEvent != null)
        {
            NativeControl.Completed += NativeControl_Completed;
        }

        OnAttachingNativeEvents();
        base.OnAttachNativeEvents();
    }

    private void NativeControl_Completed(object? sender, EventArgs e)
    {
        var thisAsIEntryCell = (IEntryCell)this;
        if (_executingCompletedEvent == null || _executingCompletedEvent.IsCompleted)
        {
            _executingCompletedEvent = thisAsIEntryCell.CompletedEvent;
            _executingCompletedEvent?.Execute(sender, e);
        }
    }

    protected override void OnDetachNativeEvents()
    {
        if (NativeControl != null)
        {
            NativeControl.Completed -= NativeControl_Completed;
        }

        OnDetachingNativeEvents();
        base.OnDetachNativeEvents();
    }

    partial void Migrated(VisualNode newNode);
    protected override void OnMigrated(VisualNode newNode)
    {
        if (newNode is EntryCell<T> @entrycell)
        {
            if (_executingCompletedEvent != null && !_executingCompletedEvent.IsCompleted)
            {
                @entrycell._executingCompletedEvent = _executingCompletedEvent;
            }
        }

        Migrated(newNode);
        base.OnMigrated(newNode);
    }
}

public partial class EntryCell : EntryCell<Microsoft.Maui.Controls.EntryCell>
{
    public EntryCell()
    {
    }

    public EntryCell(Action<Microsoft.Maui.Controls.EntryCell?> componentRefAction) : base(componentRefAction)
    {
    }

    public EntryCell(params IEnumerable<VisualNode?>? children)
    {
        if (children != null)
        {
            this.AddChildren(children);
        }
    }
}

public static partial class EntryCellExtensions
{
    /*
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    */
    public static T Text<T>(this T entryCell, string text)
        where T : IEntryCell
    {
        //entryCell.Text = text;
        entryCell.SetProperty(Microsoft.Maui.Controls.EntryCell.TextProperty, text);
        return entryCell;
    }

    public static T Text<T>(this T entryCell, Func<string> textFunc)
        where T : IEntryCell
    {
        //entryCell.Text = new PropertyValue<string>(textFunc);
        entryCell.SetProperty(Microsoft.Maui.Controls.EntryCell.TextProperty, new PropertyValue<string>(textFunc));
        return entryCell;
    }

    public static T Label<T>(this T entryCell, string label)
        where T : IEntryCell
    {
        //entryCell.Label = label;
        entryCell.SetProperty(Microsoft.Maui.Controls.EntryCell.LabelProperty, label);
        return entryCell;
    }

    public static T Label<T>(this T entryCell, Func<string> labelFunc)
        where T : IEntryCell
    {
        //entryCell.Label = new PropertyValue<string>(labelFunc);
        entryCell.SetProperty(Microsoft.Maui.Controls.EntryCell.LabelProperty, new PropertyValue<string>(labelFunc));
        return entryCell;
    }

    public static T Placeholder<T>(this T entryCell, string placeholder)
        where T : IEntryCell
    {
        //entryCell.Placeholder = placeholder;
        entryCell.SetProperty(Microsoft.Maui.Controls.EntryCell.PlaceholderProperty, placeholder);
        return entryCell;
    }

    public static T Placeholder<T>(this T entryCell, Func<string> placeholderFunc)
        where T : IEntryCell
    {
        //entryCell.Placeholder = new PropertyValue<string>(placeholderFunc);
        entryCell.SetProperty(Microsoft.Maui.Controls.EntryCell.PlaceholderProperty, new PropertyValue<string>(placeholderFunc));
        return entryCell;
    }

    public static T LabelColor<T>(this T entryCell, Microsoft.Maui.Graphics.Color labelColor)
        where T : IEntryCell
    {
        //entryCell.LabelColor = labelColor;
        entryCell.SetProperty(Microsoft.Maui.Controls.EntryCell.LabelColorProperty, labelColor);
        return entryCell;
    }

    public static T LabelColor<T>(this T entryCell, Func<Microsoft.Maui.Graphics.Color> labelColorFunc)
        where T : IEntryCell
    {
        //entryCell.LabelColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(labelColorFunc);
        entryCell.SetProperty(Microsoft.Maui.Controls.EntryCell.LabelColorProperty, new PropertyValue<Microsoft.Maui.Graphics.Color>(labelColorFunc));
        return entryCell;
    }

    public static T Keyboard<T>(this T entryCell, Microsoft.Maui.Keyboard keyboard)
        where T : IEntryCell
    {
        //entryCell.Keyboard = keyboard;
        entryCell.SetProperty(Microsoft.Maui.Controls.EntryCell.KeyboardProperty, keyboard);
        return entryCell;
    }

    public static T Keyboard<T>(this T entryCell, Func<Microsoft.Maui.Keyboard> keyboardFunc)
        where T : IEntryCell
    {
        //entryCell.Keyboard = new PropertyValue<Microsoft.Maui.Keyboard>(keyboardFunc);
        entryCell.SetProperty(Microsoft.Maui.Controls.EntryCell.KeyboardProperty, new PropertyValue<Microsoft.Maui.Keyboard>(keyboardFunc));
        return entryCell;
    }

    public static T HorizontalTextAlignment<T>(this T entryCell, Microsoft.Maui.TextAlignment horizontalTextAlignment)
        where T : IEntryCell
    {
        //entryCell.HorizontalTextAlignment = horizontalTextAlignment;
        entryCell.SetProperty(Microsoft.Maui.Controls.EntryCell.HorizontalTextAlignmentProperty, horizontalTextAlignment);
        return entryCell;
    }

    public static T HorizontalTextAlignment<T>(this T entryCell, Func<Microsoft.Maui.TextAlignment> horizontalTextAlignmentFunc)
        where T : IEntryCell
    {
        //entryCell.HorizontalTextAlignment = new PropertyValue<Microsoft.Maui.TextAlignment>(horizontalTextAlignmentFunc);
        entryCell.SetProperty(Microsoft.Maui.Controls.EntryCell.HorizontalTextAlignmentProperty, new PropertyValue<Microsoft.Maui.TextAlignment>(horizontalTextAlignmentFunc));
        return entryCell;
    }

    public static T VerticalTextAlignment<T>(this T entryCell, Microsoft.Maui.TextAlignment verticalTextAlignment)
        where T : IEntryCell
    {
        //entryCell.VerticalTextAlignment = verticalTextAlignment;
        entryCell.SetProperty(Microsoft.Maui.Controls.EntryCell.VerticalTextAlignmentProperty, verticalTextAlignment);
        return entryCell;
    }

    public static T VerticalTextAlignment<T>(this T entryCell, Func<Microsoft.Maui.TextAlignment> verticalTextAlignmentFunc)
        where T : IEntryCell
    {
        //entryCell.VerticalTextAlignment = new PropertyValue<Microsoft.Maui.TextAlignment>(verticalTextAlignmentFunc);
        entryCell.SetProperty(Microsoft.Maui.Controls.EntryCell.VerticalTextAlignmentProperty, new PropertyValue<Microsoft.Maui.TextAlignment>(verticalTextAlignmentFunc));
        return entryCell;
    }

    public static T OnCompleted<T>(this T entryCell, Action? completedAction)
        where T : IEntryCell
    {
        entryCell.CompletedEvent = new SyncEventCommand<EventArgs>(execute: completedAction);
        return entryCell;
    }

    public static T OnCompleted<T>(this T entryCell, Action<EventArgs>? completedAction)
        where T : IEntryCell
    {
        entryCell.CompletedEvent = new SyncEventCommand<EventArgs>(executeWithArgs: completedAction);
        return entryCell;
    }

    public static T OnCompleted<T>(this T entryCell, Action<object?, EventArgs>? completedAction)
        where T : IEntryCell
    {
        entryCell.CompletedEvent = new SyncEventCommand<EventArgs>(executeWithFullArgs: completedAction);
        return entryCell;
    }

    public static T OnCompleted<T>(this T entryCell, Func<Task>? completedAction, bool runInBackground = false)
        where T : IEntryCell
    {
        entryCell.CompletedEvent = new AsyncEventCommand<EventArgs>(execute: completedAction, runInBackground);
        return entryCell;
    }

    public static T OnCompleted<T>(this T entryCell, Func<EventArgs, Task>? completedAction, bool runInBackground = false)
        where T : IEntryCell
    {
        entryCell.CompletedEvent = new AsyncEventCommand<EventArgs>(executeWithArgs: completedAction, runInBackground);
        return entryCell;
    }

    public static T OnCompleted<T>(this T entryCell, Func<object?, EventArgs, Task>? completedAction, bool runInBackground = false)
        where T : IEntryCell
    {
        entryCell.CompletedEvent = new AsyncEventCommand<EventArgs>(executeWithFullArgs: completedAction, runInBackground);
        return entryCell;
    }
}

public static partial class EntryCellStyles
{
    public static Action<IEntryCell>? Default { get; set; }
    public static Dictionary<string, Action<IEntryCell>> Themes { get; } = [];
}