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
public partial interface IBaseShellItem : INavigableElement
{
    EventCommand<EventArgs>? AppearingEvent { get; set; }

    EventCommand<EventArgs>? DisappearingEvent { get; set; }
}

public partial class BaseShellItem<T> : NavigableElement<T>, IBaseShellItem where T : Microsoft.Maui.Controls.BaseShellItem, new()
{
    public BaseShellItem()
    {
        BaseShellItemStyles.Default?.Invoke(this);
    }

    public BaseShellItem(Action<T?> componentRefAction) : base(componentRefAction)
    {
        BaseShellItemStyles.Default?.Invoke(this);
    }

    EventCommand<EventArgs>? IBaseShellItem.AppearingEvent { get; set; }

    EventCommand<EventArgs>? IBaseShellItem.DisappearingEvent { get; set; }

    partial void OnBeginAnimate();
    partial void OnEndAnimate();
    protected override void OnThemeChanged()
    {
        if (ThemeKey != null && BaseShellItemStyles.Themes.TryGetValue(ThemeKey, out var styleAction))
        {
            styleAction(this);
        }

        base.OnThemeChanged();
    }

    partial void OnAttachingNativeEvents();
    partial void OnDetachingNativeEvents();
    private EventCommand<EventArgs>? _executingAppearingEvent;
    private EventCommand<EventArgs>? _executingDisappearingEvent;
    protected override void OnAttachNativeEvents()
    {
        Validate.EnsureNotNull(NativeControl);
        var thisAsIBaseShellItem = (IBaseShellItem)this;
        if (thisAsIBaseShellItem.AppearingEvent != null)
        {
            NativeControl.Appearing += NativeControl_Appearing;
        }

        if (thisAsIBaseShellItem.DisappearingEvent != null)
        {
            NativeControl.Disappearing += NativeControl_Disappearing;
        }

        OnAttachingNativeEvents();
        base.OnAttachNativeEvents();
    }

    private void NativeControl_Appearing(object? sender, EventArgs e)
    {
        var thisAsIBaseShellItem = (IBaseShellItem)this;
        if (_executingAppearingEvent == null || _executingAppearingEvent.IsCompleted)
        {
            _executingAppearingEvent = thisAsIBaseShellItem.AppearingEvent;
            _executingAppearingEvent?.Execute(sender, e);
        }
    }

    private void NativeControl_Disappearing(object? sender, EventArgs e)
    {
        var thisAsIBaseShellItem = (IBaseShellItem)this;
        if (_executingDisappearingEvent == null || _executingDisappearingEvent.IsCompleted)
        {
            _executingDisappearingEvent = thisAsIBaseShellItem.DisappearingEvent;
            _executingDisappearingEvent?.Execute(sender, e);
        }
    }

    protected override void OnDetachNativeEvents()
    {
        if (NativeControl != null)
        {
            NativeControl.Appearing -= NativeControl_Appearing;
            NativeControl.Disappearing -= NativeControl_Disappearing;
        }

        OnDetachingNativeEvents();
        base.OnDetachNativeEvents();
    }

    partial void Migrated(VisualNode newNode);
    protected override void OnMigrated(VisualNode newNode)
    {
        if (newNode is BaseShellItem<T> @baseshellitem)
        {
            if (_executingAppearingEvent != null && !_executingAppearingEvent.IsCompleted)
            {
                @baseshellitem._executingAppearingEvent = _executingAppearingEvent;
            }

            if (_executingDisappearingEvent != null && !_executingDisappearingEvent.IsCompleted)
            {
                @baseshellitem._executingDisappearingEvent = _executingDisappearingEvent;
            }
        }

        Migrated(newNode);
        base.OnMigrated(newNode);
    }
}

public partial class BaseShellItem : BaseShellItem<Microsoft.Maui.Controls.BaseShellItem>
{
    public BaseShellItem()
    {
    }

    public BaseShellItem(Action<Microsoft.Maui.Controls.BaseShellItem?> componentRefAction) : base(componentRefAction)
    {
    }

    public BaseShellItem(params IEnumerable<VisualNode?>? children)
    {
        if (children != null)
        {
            this.AddChildren(children);
        }
    }
}

public static partial class BaseShellItemExtensions
{
    /*
    
    
    
    
    
    
    
    
    
    
    
    
    */
    public static T FlyoutIcon<T>(this T baseShellItem, Microsoft.Maui.Controls.ImageSource flyoutIcon)
        where T : IBaseShellItem
    {
        //baseShellItem.FlyoutIcon = flyoutIcon;
        baseShellItem.SetProperty(Microsoft.Maui.Controls.BaseShellItem.FlyoutIconProperty, flyoutIcon);
        return baseShellItem;
    }

    public static T FlyoutIcon<T>(this T baseShellItem, Func<Microsoft.Maui.Controls.ImageSource> flyoutIconFunc)
        where T : IBaseShellItem
    {
        //baseShellItem.FlyoutIcon = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(flyoutIconFunc);
        baseShellItem.SetProperty(Microsoft.Maui.Controls.BaseShellItem.FlyoutIconProperty, new PropertyValue<Microsoft.Maui.Controls.ImageSource>(flyoutIconFunc));
        return baseShellItem;
    }

    public static T FlyoutIcon<T>(this T baseShellItem, string file)
        where T : IBaseShellItem
    {
        //baseShellItem.FlyoutIcon = Microsoft.Maui.Controls.ImageSource.FromFile(file);
        baseShellItem.SetProperty(Microsoft.Maui.Controls.BaseShellItem.FlyoutIconProperty, Microsoft.Maui.Controls.ImageSource.FromFile(file));
        return baseShellItem;
    }

    public static T FlyoutIcon<T>(this T baseShellItem, Func<string> action)
        where T : IBaseShellItem
    {
        /*baseShellItem.FlyoutIcon = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(
            () => Microsoft.Maui.Controls.ImageSource.FromFile(action()));*/
        baseShellItem.SetProperty(Microsoft.Maui.Controls.BaseShellItem.FlyoutIconProperty, new PropertyValue<Microsoft.Maui.Controls.ImageSource>(() => Microsoft.Maui.Controls.ImageSource.FromFile(action())));
        return baseShellItem;
    }

    public static T FlyoutIcon<T>(this T baseShellItem, string resourceName, Assembly sourceAssembly)
        where T : IBaseShellItem
    {
        //baseShellItem.FlyoutIcon = Microsoft.Maui.Controls.ImageSource.FromResource(resourceName, sourceAssembly);
        baseShellItem.SetProperty(Microsoft.Maui.Controls.BaseShellItem.FlyoutIconProperty, Microsoft.Maui.Controls.ImageSource.FromResource(resourceName, sourceAssembly));
        return baseShellItem;
    }

    public static T FlyoutIcon<T>(this T baseShellItem, Uri imageUri)
        where T : IBaseShellItem
    {
        //baseShellItem.FlyoutIcon = Microsoft.Maui.Controls.ImageSource.FromUri(imageUri);
        baseShellItem.SetProperty(Microsoft.Maui.Controls.BaseShellItem.FlyoutIconProperty, Microsoft.Maui.Controls.ImageSource.FromUri(imageUri));
        return baseShellItem;
    }

    public static T FlyoutIcon<T>(this T baseShellItem, Uri imageUri, bool cachingEnabled, TimeSpan cacheValidity)
        where T : IBaseShellItem
    {
        //baseShellItem.FlyoutIcon = new Microsoft.Maui.Controls.UriImageSource
        //{
        //    Uri = imageUri,
        //    CachingEnabled = cachingEnabled,
        //    CacheValidity = cacheValidity
        //};
        var newValue = new Microsoft.Maui.Controls.UriImageSource
        {
            Uri = imageUri,
            CachingEnabled = cachingEnabled,
            CacheValidity = cacheValidity
        };
        baseShellItem.SetProperty(Microsoft.Maui.Controls.BaseShellItem.FlyoutIconProperty, newValue);
        return baseShellItem;
    }

    public static T FlyoutIcon<T>(this T baseShellItem, Func<Stream> imageStream)
        where T : IBaseShellItem
    {
        //baseShellItem.FlyoutIcon = Microsoft.Maui.Controls.ImageSource.FromStream(imageStream);
        baseShellItem.SetProperty(Microsoft.Maui.Controls.BaseShellItem.FlyoutIconProperty, Microsoft.Maui.Controls.ImageSource.FromStream(imageStream));
        return baseShellItem;
    }

    public static T Icon<T>(this T baseShellItem, Microsoft.Maui.Controls.ImageSource icon)
        where T : IBaseShellItem
    {
        //baseShellItem.Icon = icon;
        baseShellItem.SetProperty(Microsoft.Maui.Controls.BaseShellItem.IconProperty, icon);
        return baseShellItem;
    }

    public static T Icon<T>(this T baseShellItem, Func<Microsoft.Maui.Controls.ImageSource> iconFunc)
        where T : IBaseShellItem
    {
        //baseShellItem.Icon = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(iconFunc);
        baseShellItem.SetProperty(Microsoft.Maui.Controls.BaseShellItem.IconProperty, new PropertyValue<Microsoft.Maui.Controls.ImageSource>(iconFunc));
        return baseShellItem;
    }

    public static T Icon<T>(this T baseShellItem, string file)
        where T : IBaseShellItem
    {
        //baseShellItem.Icon = Microsoft.Maui.Controls.ImageSource.FromFile(file);
        baseShellItem.SetProperty(Microsoft.Maui.Controls.BaseShellItem.IconProperty, Microsoft.Maui.Controls.ImageSource.FromFile(file));
        return baseShellItem;
    }

    public static T Icon<T>(this T baseShellItem, Func<string> action)
        where T : IBaseShellItem
    {
        /*baseShellItem.Icon = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(
            () => Microsoft.Maui.Controls.ImageSource.FromFile(action()));*/
        baseShellItem.SetProperty(Microsoft.Maui.Controls.BaseShellItem.IconProperty, new PropertyValue<Microsoft.Maui.Controls.ImageSource>(() => Microsoft.Maui.Controls.ImageSource.FromFile(action())));
        return baseShellItem;
    }

    public static T Icon<T>(this T baseShellItem, string resourceName, Assembly sourceAssembly)
        where T : IBaseShellItem
    {
        //baseShellItem.Icon = Microsoft.Maui.Controls.ImageSource.FromResource(resourceName, sourceAssembly);
        baseShellItem.SetProperty(Microsoft.Maui.Controls.BaseShellItem.IconProperty, Microsoft.Maui.Controls.ImageSource.FromResource(resourceName, sourceAssembly));
        return baseShellItem;
    }

    public static T Icon<T>(this T baseShellItem, Uri imageUri)
        where T : IBaseShellItem
    {
        //baseShellItem.Icon = Microsoft.Maui.Controls.ImageSource.FromUri(imageUri);
        baseShellItem.SetProperty(Microsoft.Maui.Controls.BaseShellItem.IconProperty, Microsoft.Maui.Controls.ImageSource.FromUri(imageUri));
        return baseShellItem;
    }

    public static T Icon<T>(this T baseShellItem, Uri imageUri, bool cachingEnabled, TimeSpan cacheValidity)
        where T : IBaseShellItem
    {
        //baseShellItem.Icon = new Microsoft.Maui.Controls.UriImageSource
        //{
        //    Uri = imageUri,
        //    CachingEnabled = cachingEnabled,
        //    CacheValidity = cacheValidity
        //};
        var newValue = new Microsoft.Maui.Controls.UriImageSource
        {
            Uri = imageUri,
            CachingEnabled = cachingEnabled,
            CacheValidity = cacheValidity
        };
        baseShellItem.SetProperty(Microsoft.Maui.Controls.BaseShellItem.IconProperty, newValue);
        return baseShellItem;
    }

    public static T Icon<T>(this T baseShellItem, Func<Stream> imageStream)
        where T : IBaseShellItem
    {
        //baseShellItem.Icon = Microsoft.Maui.Controls.ImageSource.FromStream(imageStream);
        baseShellItem.SetProperty(Microsoft.Maui.Controls.BaseShellItem.IconProperty, Microsoft.Maui.Controls.ImageSource.FromStream(imageStream));
        return baseShellItem;
    }

    public static T IsEnabled<T>(this T baseShellItem, bool isEnabled)
        where T : IBaseShellItem
    {
        //baseShellItem.IsEnabled = isEnabled;
        baseShellItem.SetProperty(Microsoft.Maui.Controls.BaseShellItem.IsEnabledProperty, isEnabled);
        return baseShellItem;
    }

    public static T IsEnabled<T>(this T baseShellItem, Func<bool> isEnabledFunc)
        where T : IBaseShellItem
    {
        //baseShellItem.IsEnabled = new PropertyValue<bool>(isEnabledFunc);
        baseShellItem.SetProperty(Microsoft.Maui.Controls.BaseShellItem.IsEnabledProperty, new PropertyValue<bool>(isEnabledFunc));
        return baseShellItem;
    }

    public static T Title<T>(this T baseShellItem, string title)
        where T : IBaseShellItem
    {
        //baseShellItem.Title = title;
        baseShellItem.SetProperty(Microsoft.Maui.Controls.BaseShellItem.TitleProperty, title);
        return baseShellItem;
    }

    public static T Title<T>(this T baseShellItem, Func<string> titleFunc)
        where T : IBaseShellItem
    {
        //baseShellItem.Title = new PropertyValue<string>(titleFunc);
        baseShellItem.SetProperty(Microsoft.Maui.Controls.BaseShellItem.TitleProperty, new PropertyValue<string>(titleFunc));
        return baseShellItem;
    }

    public static T IsVisible<T>(this T baseShellItem, bool isVisible)
        where T : IBaseShellItem
    {
        //baseShellItem.IsVisible = isVisible;
        baseShellItem.SetProperty(Microsoft.Maui.Controls.BaseShellItem.IsVisibleProperty, isVisible);
        return baseShellItem;
    }

    public static T IsVisible<T>(this T baseShellItem, Func<bool> isVisibleFunc)
        where T : IBaseShellItem
    {
        //baseShellItem.IsVisible = new PropertyValue<bool>(isVisibleFunc);
        baseShellItem.SetProperty(Microsoft.Maui.Controls.BaseShellItem.IsVisibleProperty, new PropertyValue<bool>(isVisibleFunc));
        return baseShellItem;
    }

    public static T FlyoutItemIsVisible<T>(this T baseShellItem, bool flyoutItemIsVisible)
        where T : IBaseShellItem
    {
        //baseShellItem.FlyoutItemIsVisible = flyoutItemIsVisible;
        baseShellItem.SetProperty(Microsoft.Maui.Controls.BaseShellItem.FlyoutItemIsVisibleProperty, flyoutItemIsVisible);
        return baseShellItem;
    }

    public static T FlyoutItemIsVisible<T>(this T baseShellItem, Func<bool> flyoutItemIsVisibleFunc)
        where T : IBaseShellItem
    {
        //baseShellItem.FlyoutItemIsVisible = new PropertyValue<bool>(flyoutItemIsVisibleFunc);
        baseShellItem.SetProperty(Microsoft.Maui.Controls.BaseShellItem.FlyoutItemIsVisibleProperty, new PropertyValue<bool>(flyoutItemIsVisibleFunc));
        return baseShellItem;
    }

    public static T OnAppearing<T>(this T baseShellItem, Action? appearingAction)
        where T : IBaseShellItem
    {
        baseShellItem.AppearingEvent = new SyncEventCommand<EventArgs>(execute: appearingAction);
        return baseShellItem;
    }

    public static T OnAppearing<T>(this T baseShellItem, Action<EventArgs>? appearingAction)
        where T : IBaseShellItem
    {
        baseShellItem.AppearingEvent = new SyncEventCommand<EventArgs>(executeWithArgs: appearingAction);
        return baseShellItem;
    }

    public static T OnAppearing<T>(this T baseShellItem, Action<object?, EventArgs>? appearingAction)
        where T : IBaseShellItem
    {
        baseShellItem.AppearingEvent = new SyncEventCommand<EventArgs>(executeWithFullArgs: appearingAction);
        return baseShellItem;
    }

    public static T OnAppearing<T>(this T baseShellItem, Func<Task>? appearingAction, bool runInBackground = false)
        where T : IBaseShellItem
    {
        baseShellItem.AppearingEvent = new AsyncEventCommand<EventArgs>(execute: appearingAction, runInBackground);
        return baseShellItem;
    }

    public static T OnAppearing<T>(this T baseShellItem, Func<EventArgs, Task>? appearingAction, bool runInBackground = false)
        where T : IBaseShellItem
    {
        baseShellItem.AppearingEvent = new AsyncEventCommand<EventArgs>(executeWithArgs: appearingAction, runInBackground);
        return baseShellItem;
    }

    public static T OnAppearing<T>(this T baseShellItem, Func<object?, EventArgs, Task>? appearingAction, bool runInBackground = false)
        where T : IBaseShellItem
    {
        baseShellItem.AppearingEvent = new AsyncEventCommand<EventArgs>(executeWithFullArgs: appearingAction, runInBackground);
        return baseShellItem;
    }

    public static T OnDisappearing<T>(this T baseShellItem, Action? disappearingAction)
        where T : IBaseShellItem
    {
        baseShellItem.DisappearingEvent = new SyncEventCommand<EventArgs>(execute: disappearingAction);
        return baseShellItem;
    }

    public static T OnDisappearing<T>(this T baseShellItem, Action<EventArgs>? disappearingAction)
        where T : IBaseShellItem
    {
        baseShellItem.DisappearingEvent = new SyncEventCommand<EventArgs>(executeWithArgs: disappearingAction);
        return baseShellItem;
    }

    public static T OnDisappearing<T>(this T baseShellItem, Action<object?, EventArgs>? disappearingAction)
        where T : IBaseShellItem
    {
        baseShellItem.DisappearingEvent = new SyncEventCommand<EventArgs>(executeWithFullArgs: disappearingAction);
        return baseShellItem;
    }

    public static T OnDisappearing<T>(this T baseShellItem, Func<Task>? disappearingAction, bool runInBackground = false)
        where T : IBaseShellItem
    {
        baseShellItem.DisappearingEvent = new AsyncEventCommand<EventArgs>(execute: disappearingAction, runInBackground);
        return baseShellItem;
    }

    public static T OnDisappearing<T>(this T baseShellItem, Func<EventArgs, Task>? disappearingAction, bool runInBackground = false)
        where T : IBaseShellItem
    {
        baseShellItem.DisappearingEvent = new AsyncEventCommand<EventArgs>(executeWithArgs: disappearingAction, runInBackground);
        return baseShellItem;
    }

    public static T OnDisappearing<T>(this T baseShellItem, Func<object?, EventArgs, Task>? disappearingAction, bool runInBackground = false)
        where T : IBaseShellItem
    {
        baseShellItem.DisappearingEvent = new AsyncEventCommand<EventArgs>(executeWithFullArgs: disappearingAction, runInBackground);
        return baseShellItem;
    }
}

public static partial class BaseShellItemStyles
{
    public static Action<IBaseShellItem>? Default { get; set; }
    public static Dictionary<string, Action<IBaseShellItem>> Themes { get; } = [];
}