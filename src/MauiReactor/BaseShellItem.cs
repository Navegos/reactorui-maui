using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

using MauiReactor.Animations;
//using MauiReactor.Shapes;
using MauiReactor.Internals;

namespace MauiReactor
{
    public partial interface IBaseShellItem : INavigableElement
    {
        PropertyValue<Microsoft.Maui.Controls.ImageSource>? FlyoutIcon { get; set; }
        PropertyValue<Microsoft.Maui.Controls.ImageSource>? Icon { get; set; }
        PropertyValue<bool>? IsEnabled { get; set; }
        PropertyValue<string>? Title { get; set; }
        PropertyValue<bool>? IsVisible { get; set; }

        Action? AppearingAction { get; set; }
        Action<object?, EventArgs>? AppearingActionWithArgs { get; set; }
        Action? DisappearingAction { get; set; }
        Action<object?, EventArgs>? DisappearingActionWithArgs { get; set; }

    }
    public partial class BaseShellItem<T> : NavigableElement<T>, IBaseShellItem where T : Microsoft.Maui.Controls.BaseShellItem, new()
    {
        public BaseShellItem()
        {

        }

        public BaseShellItem(Action<T?> componentRefAction)
            : base(componentRefAction)
        {

        }

        PropertyValue<Microsoft.Maui.Controls.ImageSource>? IBaseShellItem.FlyoutIcon { get; set; }
        PropertyValue<Microsoft.Maui.Controls.ImageSource>? IBaseShellItem.Icon { get; set; }
        PropertyValue<bool>? IBaseShellItem.IsEnabled { get; set; }
        PropertyValue<string>? IBaseShellItem.Title { get; set; }
        PropertyValue<bool>? IBaseShellItem.IsVisible { get; set; }

        Action? IBaseShellItem.AppearingAction { get; set; }
        Action<object?, EventArgs>? IBaseShellItem.AppearingActionWithArgs { get; set; }
        Action? IBaseShellItem.DisappearingAction { get; set; }
        Action<object?, EventArgs>? IBaseShellItem.DisappearingActionWithArgs { get; set; }

        protected override void OnUpdate()
        {
            OnBeginUpdate();

            Validate.EnsureNotNull(NativeControl);
            var thisAsIBaseShellItem = (IBaseShellItem)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.BaseShellItem.FlyoutIconProperty, thisAsIBaseShellItem.FlyoutIcon);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.BaseShellItem.IconProperty, thisAsIBaseShellItem.Icon);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.BaseShellItem.IsEnabledProperty, thisAsIBaseShellItem.IsEnabled);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.BaseShellItem.TitleProperty, thisAsIBaseShellItem.Title);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.BaseShellItem.IsVisibleProperty, thisAsIBaseShellItem.IsVisible);


            base.OnUpdate();

            OnEndUpdate();
        }

        partial void OnBeginUpdate();
        partial void OnEndUpdate();

        protected override void OnAttachNativeEvents()
        {
            Validate.EnsureNotNull(NativeControl);

            var thisAsIBaseShellItem = (IBaseShellItem)this;
            if (thisAsIBaseShellItem.AppearingAction != null || thisAsIBaseShellItem.AppearingActionWithArgs != null)
            {
                NativeControl.Appearing += NativeControl_Appearing;
            }
            if (thisAsIBaseShellItem.DisappearingAction != null || thisAsIBaseShellItem.DisappearingActionWithArgs != null)
            {
                NativeControl.Disappearing += NativeControl_Disappearing;
            }

            base.OnAttachNativeEvents();
        }

        private void NativeControl_Appearing(object? sender, EventArgs e)
        {
            var thisAsIBaseShellItem = (IBaseShellItem)this;
            thisAsIBaseShellItem.AppearingAction?.Invoke();
            thisAsIBaseShellItem.AppearingActionWithArgs?.Invoke(sender, e);
        }
        private void NativeControl_Disappearing(object? sender, EventArgs e)
        {
            var thisAsIBaseShellItem = (IBaseShellItem)this;
            thisAsIBaseShellItem.DisappearingAction?.Invoke();
            thisAsIBaseShellItem.DisappearingActionWithArgs?.Invoke(sender, e);
        }

        protected override void OnDetachNativeEvents()
        {
            if (NativeControl != null)
            {
                NativeControl.Appearing -= NativeControl_Appearing;
                NativeControl.Disappearing -= NativeControl_Disappearing;
            }

            base.OnDetachNativeEvents();
        }

    }

    public partial class BaseShellItem : BaseShellItem<Microsoft.Maui.Controls.BaseShellItem>
    {
        public BaseShellItem()
        {

        }

        public BaseShellItem(Action<Microsoft.Maui.Controls.BaseShellItem?> componentRefAction)
            : base(componentRefAction)
        {

        }
    }

    public static partial class BaseShellItemExtensions
    {
        public static T FlyoutIcon<T>(this T baseShellItem, Microsoft.Maui.Controls.ImageSource flyoutIcon) where T : IBaseShellItem
        {
            baseShellItem.FlyoutIcon = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(flyoutIcon);
            return baseShellItem;
        }

        public static T FlyoutIcon<T>(this T baseShellItem, Func<Microsoft.Maui.Controls.ImageSource> flyoutIconFunc) where T : IBaseShellItem
        {
            baseShellItem.FlyoutIcon = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(flyoutIconFunc);
            return baseShellItem;
        }


        public static T Flyo<T>(this T baseShellItem, string file) where T : IBaseShellItem
        {
            baseShellItem.FlyoutIcon = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(Microsoft.Maui.Controls.ImageSource.FromFile(file));
            return baseShellItem;
        }
        public static T Flyo<T>(this T baseShellItem, string fileAndroid, string fileiOS) where T : IBaseShellItem
        {
            baseShellItem.FlyoutIcon = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(Device.RuntimePlatform == Device.Android ? Microsoft.Maui.Controls.ImageSource.FromFile(fileAndroid) : Microsoft.Maui.Controls.ImageSource.FromFile(fileiOS));
            return baseShellItem;
        }
        public static T Flyo<T>(this T baseShellItem, string resourceName, Assembly sourceAssembly) where T : IBaseShellItem
        {
            baseShellItem.FlyoutIcon = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(Microsoft.Maui.Controls.ImageSource.FromResource(resourceName, sourceAssembly));
            return baseShellItem;
        }
        public static T Flyo<T>(this T baseShellItem, Uri imageUri) where T : IBaseShellItem
        {
            baseShellItem.FlyoutIcon = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(Microsoft.Maui.Controls.ImageSource.FromUri(imageUri));
            return baseShellItem;
        }
        public static T Flyo<T>(this T baseShellItem, Uri imageUri, bool cachingEnabled, TimeSpan cacheValidity) where T : IBaseShellItem
        {
            baseShellItem.FlyoutIcon = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(new UriImageSource
            {
                Uri = imageUri,
                CachingEnabled = cachingEnabled,
                CacheValidity = cacheValidity
            });
            return baseShellItem;
        }
        public static T Flyo<T>(this T baseShellItem, Func<Stream> imageStream) where T : IBaseShellItem
        {
            baseShellItem.FlyoutIcon = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(Microsoft.Maui.Controls.ImageSource.FromStream(imageStream));
            return baseShellItem;
        }

        public static T Icon<T>(this T baseShellItem, Microsoft.Maui.Controls.ImageSource icon) where T : IBaseShellItem
        {
            baseShellItem.Icon = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(icon);
            return baseShellItem;
        }

        public static T Icon<T>(this T baseShellItem, Func<Microsoft.Maui.Controls.ImageSource> iconFunc) where T : IBaseShellItem
        {
            baseShellItem.Icon = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(iconFunc);
            return baseShellItem;
        }


        public static T Icon<T>(this T baseShellItem, string file) where T : IBaseShellItem
        {
            baseShellItem.Icon = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(Microsoft.Maui.Controls.ImageSource.FromFile(file));
            return baseShellItem;
        }
        public static T Icon<T>(this T baseShellItem, string fileAndroid, string fileiOS) where T : IBaseShellItem
        {
            baseShellItem.Icon = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(Device.RuntimePlatform == Device.Android ? Microsoft.Maui.Controls.ImageSource.FromFile(fileAndroid) : Microsoft.Maui.Controls.ImageSource.FromFile(fileiOS));
            return baseShellItem;
        }
        public static T Icon<T>(this T baseShellItem, string resourceName, Assembly sourceAssembly) where T : IBaseShellItem
        {
            baseShellItem.Icon = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(Microsoft.Maui.Controls.ImageSource.FromResource(resourceName, sourceAssembly));
            return baseShellItem;
        }
        public static T Icon<T>(this T baseShellItem, Uri imageUri) where T : IBaseShellItem
        {
            baseShellItem.Icon = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(Microsoft.Maui.Controls.ImageSource.FromUri(imageUri));
            return baseShellItem;
        }
        public static T Icon<T>(this T baseShellItem, Uri imageUri, bool cachingEnabled, TimeSpan cacheValidity) where T : IBaseShellItem
        {
            baseShellItem.Icon = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(new UriImageSource
            {
                Uri = imageUri,
                CachingEnabled = cachingEnabled,
                CacheValidity = cacheValidity
            });
            return baseShellItem;
        }
        public static T Icon<T>(this T baseShellItem, Func<Stream> imageStream) where T : IBaseShellItem
        {
            baseShellItem.Icon = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(Microsoft.Maui.Controls.ImageSource.FromStream(imageStream));
            return baseShellItem;
        }

        public static T IsEnabled<T>(this T baseShellItem, bool isEnabled) where T : IBaseShellItem
        {
            baseShellItem.IsEnabled = new PropertyValue<bool>(isEnabled);
            return baseShellItem;
        }

        public static T IsEnabled<T>(this T baseShellItem, Func<bool> isEnabledFunc) where T : IBaseShellItem
        {
            baseShellItem.IsEnabled = new PropertyValue<bool>(isEnabledFunc);
            return baseShellItem;
        }



        public static T Title<T>(this T baseShellItem, string title) where T : IBaseShellItem
        {
            baseShellItem.Title = new PropertyValue<string>(title);
            return baseShellItem;
        }

        public static T Title<T>(this T baseShellItem, Func<string> titleFunc) where T : IBaseShellItem
        {
            baseShellItem.Title = new PropertyValue<string>(titleFunc);
            return baseShellItem;
        }



        public static T IsVisible<T>(this T baseShellItem, bool isVisible) where T : IBaseShellItem
        {
            baseShellItem.IsVisible = new PropertyValue<bool>(isVisible);
            return baseShellItem;
        }

        public static T IsVisible<T>(this T baseShellItem, Func<bool> isVisibleFunc) where T : IBaseShellItem
        {
            baseShellItem.IsVisible = new PropertyValue<bool>(isVisibleFunc);
            return baseShellItem;
        }




        public static T OnAppearing<T>(this T baseShellItem, Action appearingAction) where T : IBaseShellItem
        {
            baseShellItem.AppearingAction = appearingAction;
            return baseShellItem;
        }

        public static T OnAppearing<T>(this T baseShellItem, Action<object?, EventArgs> appearingActionWithArgs) where T : IBaseShellItem
        {
            baseShellItem.AppearingActionWithArgs = appearingActionWithArgs;
            return baseShellItem;
        }
        public static T OnDisappearing<T>(this T baseShellItem, Action disappearingAction) where T : IBaseShellItem
        {
            baseShellItem.DisappearingAction = disappearingAction;
            return baseShellItem;
        }

        public static T OnDisappearing<T>(this T baseShellItem, Action<object?, EventArgs> disappearingActionWithArgs) where T : IBaseShellItem
        {
            baseShellItem.DisappearingActionWithArgs = disappearingActionWithArgs;
            return baseShellItem;
        }
    }
}