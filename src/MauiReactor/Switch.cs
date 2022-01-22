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
    public partial interface ISwitch : IView
    {
        PropertyValue<bool>? IsToggled { get; set; }
        PropertyValue<Microsoft.Maui.Graphics.Color>? OnColor { get; set; }
        PropertyValue<Microsoft.Maui.Graphics.Color>? ThumbColor { get; set; }

        Action? ToggledAction { get; set; }
        Action<object?, ToggledEventArgs>? ToggledActionWithArgs { get; set; }

    }
    public partial class Switch<T> : View<T>, ISwitch where T : Microsoft.Maui.Controls.Switch, new()
    {
        public Switch()
        {

        }

        public Switch(Action<T?> componentRefAction)
            : base(componentRefAction)
        {

        }

        PropertyValue<bool>? ISwitch.IsToggled { get; set; }
        PropertyValue<Microsoft.Maui.Graphics.Color>? ISwitch.OnColor { get; set; }
        PropertyValue<Microsoft.Maui.Graphics.Color>? ISwitch.ThumbColor { get; set; }

        Action? ISwitch.ToggledAction { get; set; }
        Action<object?, ToggledEventArgs>? ISwitch.ToggledActionWithArgs { get; set; }

        protected override void OnUpdate()
        {
            OnBeginUpdate();

            Validate.EnsureNotNull(NativeControl);
            var thisAsISwitch = (ISwitch)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Switch.IsToggledProperty, thisAsISwitch.IsToggled);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Switch.OnColorProperty, thisAsISwitch.OnColor);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Switch.ThumbColorProperty, thisAsISwitch.ThumbColor);


            base.OnUpdate();

            OnEndUpdate();
        }

        partial void OnBeginUpdate();
        partial void OnEndUpdate();

        protected override void OnAttachNativeEvents()
        {
            Validate.EnsureNotNull(NativeControl);

            var thisAsISwitch = (ISwitch)this;
            if (thisAsISwitch.ToggledAction != null || thisAsISwitch.ToggledActionWithArgs != null)
            {
                NativeControl.Toggled += NativeControl_Toggled;
            }

            base.OnAttachNativeEvents();
        }

        private void NativeControl_Toggled(object? sender, ToggledEventArgs e)
        {
            var thisAsISwitch = (ISwitch)this;
            thisAsISwitch.ToggledAction?.Invoke();
            thisAsISwitch.ToggledActionWithArgs?.Invoke(sender, e);
        }

        protected override void OnDetachNativeEvents()
        {
            if (NativeControl != null)
            {
                NativeControl.Toggled -= NativeControl_Toggled;
            }

            base.OnDetachNativeEvents();
        }

    }

    public partial class Switch : Switch<Microsoft.Maui.Controls.Switch>
    {
        public Switch()
        {

        }

        public Switch(Action<Microsoft.Maui.Controls.Switch?> componentRefAction)
            : base(componentRefAction)
        {

        }
    }

    public static partial class SwitchExtensions
    {
        public static T IsToggled<T>(this T @switch, bool isToggled) where T : ISwitch
        {
            @switch.IsToggled = new PropertyValue<bool>(isToggled);
            return @switch;
        }

        public static T IsToggled<T>(this T @switch, Func<bool> isToggledFunc) where T : ISwitch
        {
            @switch.IsToggled = new PropertyValue<bool>(isToggledFunc);
            return @switch;
        }



        public static T OnColor<T>(this T @switch, Microsoft.Maui.Graphics.Color onColor) where T : ISwitch
        {
            @switch.OnColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(onColor);
            return @switch;
        }

        public static T OnColor<T>(this T @switch, Func<Microsoft.Maui.Graphics.Color> onColorFunc) where T : ISwitch
        {
            @switch.OnColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(onColorFunc);
            return @switch;
        }



        public static T ThumbColor<T>(this T @switch, Microsoft.Maui.Graphics.Color thumbColor) where T : ISwitch
        {
            @switch.ThumbColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(thumbColor);
            return @switch;
        }

        public static T ThumbColor<T>(this T @switch, Func<Microsoft.Maui.Graphics.Color> thumbColorFunc) where T : ISwitch
        {
            @switch.ThumbColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(thumbColorFunc);
            return @switch;
        }




        public static T OnToggled<T>(this T @switch, Action toggledAction) where T : ISwitch
        {
            @switch.ToggledAction = toggledAction;
            return @switch;
        }

        public static T OnToggled<T>(this T @switch, Action<object?, ToggledEventArgs> toggledActionWithArgs) where T : ISwitch
        {
            @switch.ToggledActionWithArgs = toggledActionWithArgs;
            return @switch;
        }
    }
}