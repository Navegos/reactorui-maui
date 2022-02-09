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

namespace MauiReactor
{
    public partial interface IInputView : IView
    {
        PropertyValue<string>? Text { get; set; }
        PropertyValue<Microsoft.Maui.Keyboard>? Keyboard { get; set; }
        PropertyValue<bool>? IsSpellCheckEnabled { get; set; }
        PropertyValue<int>? MaxLength { get; set; }
        PropertyValue<bool>? IsReadOnly { get; set; }
        PropertyValue<string>? Placeholder { get; set; }
        PropertyValue<Microsoft.Maui.Graphics.Color>? PlaceholderColor { get; set; }
        PropertyValue<Microsoft.Maui.Graphics.Color>? TextColor { get; set; }
        PropertyValue<double>? CharacterSpacing { get; set; }
        PropertyValue<Microsoft.Maui.TextTransform>? TextTransform { get; set; }

        Action? TextChangedAction { get; set; }
        Action<object?, TextChangedEventArgs>? TextChangedActionWithArgs { get; set; }

    }
    public abstract partial class InputView<T> : View<T>, IInputView where T : Microsoft.Maui.Controls.InputView, new()
    {
        protected InputView()
        {

        }

        protected InputView(Action<T?> componentRefAction)
            : base(componentRefAction)
        {

        }

        PropertyValue<string>? IInputView.Text { get; set; }
        PropertyValue<Microsoft.Maui.Keyboard>? IInputView.Keyboard { get; set; }
        PropertyValue<bool>? IInputView.IsSpellCheckEnabled { get; set; }
        PropertyValue<int>? IInputView.MaxLength { get; set; }
        PropertyValue<bool>? IInputView.IsReadOnly { get; set; }
        PropertyValue<string>? IInputView.Placeholder { get; set; }
        PropertyValue<Microsoft.Maui.Graphics.Color>? IInputView.PlaceholderColor { get; set; }
        PropertyValue<Microsoft.Maui.Graphics.Color>? IInputView.TextColor { get; set; }
        PropertyValue<double>? IInputView.CharacterSpacing { get; set; }
        PropertyValue<Microsoft.Maui.TextTransform>? IInputView.TextTransform { get; set; }

        Action? IInputView.TextChangedAction { get; set; }
        Action<object?, TextChangedEventArgs>? IInputView.TextChangedActionWithArgs { get; set; }

        protected override void OnUpdate()
        {
            OnBeginUpdate();

            Validate.EnsureNotNull(NativeControl);
            var thisAsIInputView = (IInputView)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.InputView.TextProperty, thisAsIInputView.Text);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.InputView.KeyboardProperty, thisAsIInputView.Keyboard);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.InputView.IsSpellCheckEnabledProperty, thisAsIInputView.IsSpellCheckEnabled);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.InputView.MaxLengthProperty, thisAsIInputView.MaxLength);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.InputView.IsReadOnlyProperty, thisAsIInputView.IsReadOnly);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.InputView.PlaceholderProperty, thisAsIInputView.Placeholder);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.InputView.PlaceholderColorProperty, thisAsIInputView.PlaceholderColor);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.InputView.TextColorProperty, thisAsIInputView.TextColor);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.InputView.CharacterSpacingProperty, thisAsIInputView.CharacterSpacing);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.InputView.TextTransformProperty, thisAsIInputView.TextTransform);


            base.OnUpdate();

            OnEndUpdate();
        }

        protected override void OnAnimate()
        {
            Validate.EnsureNotNull(NativeControl);
            var thisAsIInputView = (IInputView)this;

            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.InputView.CharacterSpacingProperty, thisAsIInputView.CharacterSpacing);

            base.OnAnimate();
        }

        partial void OnBeginUpdate();
        partial void OnEndUpdate();

        protected override void OnAttachNativeEvents()
        {
            Validate.EnsureNotNull(NativeControl);

            var thisAsIInputView = (IInputView)this;
            if (thisAsIInputView.TextChangedAction != null || thisAsIInputView.TextChangedActionWithArgs != null)
            {
                NativeControl.TextChanged += NativeControl_TextChanged;
            }

            base.OnAttachNativeEvents();
        }

        private void NativeControl_TextChanged(object? sender, TextChangedEventArgs e)
        {
            var thisAsIInputView = (IInputView)this;
            thisAsIInputView.TextChangedAction?.Invoke();
            thisAsIInputView.TextChangedActionWithArgs?.Invoke(sender, e);
        }

        protected override void OnDetachNativeEvents()
        {
            if (NativeControl != null)
            {
                NativeControl.TextChanged -= NativeControl_TextChanged;
            }

            base.OnDetachNativeEvents();
        }

    }


    public static partial class InputViewExtensions
    {
        public static T Text<T>(this T inputView, string text) where T : IInputView
        {
            inputView.Text = new PropertyValue<string>(text);
            return inputView;
        }

        public static T Text<T>(this T inputView, Func<string> textFunc) where T : IInputView
        {
            inputView.Text = new PropertyValue<string>(textFunc);
            return inputView;
        }



        public static T Keyboard<T>(this T inputView, Microsoft.Maui.Keyboard keyboard) where T : IInputView
        {
            inputView.Keyboard = new PropertyValue<Microsoft.Maui.Keyboard>(keyboard);
            return inputView;
        }

        public static T Keyboard<T>(this T inputView, Func<Microsoft.Maui.Keyboard> keyboardFunc) where T : IInputView
        {
            inputView.Keyboard = new PropertyValue<Microsoft.Maui.Keyboard>(keyboardFunc);
            return inputView;
        }



        public static T IsSpellCheckEnabled<T>(this T inputView, bool isSpellCheckEnabled) where T : IInputView
        {
            inputView.IsSpellCheckEnabled = new PropertyValue<bool>(isSpellCheckEnabled);
            return inputView;
        }

        public static T IsSpellCheckEnabled<T>(this T inputView, Func<bool> isSpellCheckEnabledFunc) where T : IInputView
        {
            inputView.IsSpellCheckEnabled = new PropertyValue<bool>(isSpellCheckEnabledFunc);
            return inputView;
        }



        public static T MaxLength<T>(this T inputView, int maxLength) where T : IInputView
        {
            inputView.MaxLength = new PropertyValue<int>(maxLength);
            return inputView;
        }

        public static T MaxLength<T>(this T inputView, Func<int> maxLengthFunc) where T : IInputView
        {
            inputView.MaxLength = new PropertyValue<int>(maxLengthFunc);
            return inputView;
        }



        public static T IsReadOnly<T>(this T inputView, bool isReadOnly) where T : IInputView
        {
            inputView.IsReadOnly = new PropertyValue<bool>(isReadOnly);
            return inputView;
        }

        public static T IsReadOnly<T>(this T inputView, Func<bool> isReadOnlyFunc) where T : IInputView
        {
            inputView.IsReadOnly = new PropertyValue<bool>(isReadOnlyFunc);
            return inputView;
        }



        public static T Placeholder<T>(this T inputView, string placeholder) where T : IInputView
        {
            inputView.Placeholder = new PropertyValue<string>(placeholder);
            return inputView;
        }

        public static T Placeholder<T>(this T inputView, Func<string> placeholderFunc) where T : IInputView
        {
            inputView.Placeholder = new PropertyValue<string>(placeholderFunc);
            return inputView;
        }



        public static T PlaceholderColor<T>(this T inputView, Microsoft.Maui.Graphics.Color placeholderColor) where T : IInputView
        {
            inputView.PlaceholderColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(placeholderColor);
            return inputView;
        }

        public static T PlaceholderColor<T>(this T inputView, Func<Microsoft.Maui.Graphics.Color> placeholderColorFunc) where T : IInputView
        {
            inputView.PlaceholderColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(placeholderColorFunc);
            return inputView;
        }



        public static T TextColor<T>(this T inputView, Microsoft.Maui.Graphics.Color textColor) where T : IInputView
        {
            inputView.TextColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(textColor);
            return inputView;
        }

        public static T TextColor<T>(this T inputView, Func<Microsoft.Maui.Graphics.Color> textColorFunc) where T : IInputView
        {
            inputView.TextColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(textColorFunc);
            return inputView;
        }



        public static T CharacterSpacing<T>(this T inputView, double characterSpacing, RxDoubleAnimation? customAnimation = null) where T : IInputView
        {
            inputView.CharacterSpacing = new PropertyValue<double>(characterSpacing);
            inputView.AppendAnimatable(Microsoft.Maui.Controls.InputView.CharacterSpacingProperty, customAnimation ?? new RxDoubleAnimation(characterSpacing), v => inputView.CharacterSpacing = new PropertyValue<double>(v.CurrentValue()));
            return inputView;
        }

        public static T CharacterSpacing<T>(this T inputView, Func<double> characterSpacingFunc) where T : IInputView
        {
            inputView.CharacterSpacing = new PropertyValue<double>(characterSpacingFunc);
            return inputView;
        }



        public static T TextTransform<T>(this T inputView, Microsoft.Maui.TextTransform textTransform) where T : IInputView
        {
            inputView.TextTransform = new PropertyValue<Microsoft.Maui.TextTransform>(textTransform);
            return inputView;
        }

        public static T TextTransform<T>(this T inputView, Func<Microsoft.Maui.TextTransform> textTransformFunc) where T : IInputView
        {
            inputView.TextTransform = new PropertyValue<Microsoft.Maui.TextTransform>(textTransformFunc);
            return inputView;
        }




        public static T OnTextChanged<T>(this T inputView, Action textChangedAction) where T : IInputView
        {
            inputView.TextChangedAction = textChangedAction;
            return inputView;
        }

        public static T OnTextChanged<T>(this T inputView, Action<object?, TextChangedEventArgs> textChangedActionWithArgs) where T : IInputView
        {
            inputView.TextChangedActionWithArgs = textChangedActionWithArgs;
            return inputView;
        }
    }
}