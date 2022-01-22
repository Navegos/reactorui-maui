using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

using MauiReactor.Animations;
//using MauiReactor.Shapes;
using MauiReactor.Internals;

namespace MauiReactor.Shapes
{
    public partial interface IShape : IView
    {
        PropertyValue<Microsoft.Maui.Controls.Brush>? Fill { get; set; }
        PropertyValue<Microsoft.Maui.Controls.Brush>? Stroke { get; set; }
        PropertyValue<double>? StrokeThickness { get; set; }
        PropertyValue<Microsoft.Maui.Controls.DoubleCollection>? StrokeDashArray { get; set; }
        PropertyValue<double>? StrokeDashOffset { get; set; }
        PropertyValue<Microsoft.Maui.Controls.Shapes.PenLineCap>? StrokeLineCap { get; set; }
        PropertyValue<Microsoft.Maui.Controls.Shapes.PenLineJoin>? StrokeLineJoin { get; set; }
        PropertyValue<double>? StrokeMiterLimit { get; set; }
        PropertyValue<Microsoft.Maui.Controls.Stretch>? Aspect { get; set; }


    }
    public abstract partial class Shape<T> : View<T>, IShape where T : Microsoft.Maui.Controls.Shapes.Shape, new()
    {
        protected Shape()
        {

        }

        protected Shape(Action<T?> componentRefAction)
            : base(componentRefAction)
        {

        }

        PropertyValue<Microsoft.Maui.Controls.Brush>? IShape.Fill { get; set; }
        PropertyValue<Microsoft.Maui.Controls.Brush>? IShape.Stroke { get; set; }
        PropertyValue<double>? IShape.StrokeThickness { get; set; }
        PropertyValue<Microsoft.Maui.Controls.DoubleCollection>? IShape.StrokeDashArray { get; set; }
        PropertyValue<double>? IShape.StrokeDashOffset { get; set; }
        PropertyValue<Microsoft.Maui.Controls.Shapes.PenLineCap>? IShape.StrokeLineCap { get; set; }
        PropertyValue<Microsoft.Maui.Controls.Shapes.PenLineJoin>? IShape.StrokeLineJoin { get; set; }
        PropertyValue<double>? IShape.StrokeMiterLimit { get; set; }
        PropertyValue<Microsoft.Maui.Controls.Stretch>? IShape.Aspect { get; set; }


        protected override void OnUpdate()
        {
            OnBeginUpdate();

            Validate.EnsureNotNull(NativeControl);
            var thisAsIShape = (IShape)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shapes.Shape.FillProperty, thisAsIShape.Fill);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shapes.Shape.StrokeProperty, thisAsIShape.Stroke);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shapes.Shape.StrokeThicknessProperty, thisAsIShape.StrokeThickness);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shapes.Shape.StrokeDashArrayProperty, thisAsIShape.StrokeDashArray);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shapes.Shape.StrokeDashOffsetProperty, thisAsIShape.StrokeDashOffset);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shapes.Shape.StrokeLineCapProperty, thisAsIShape.StrokeLineCap);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shapes.Shape.StrokeLineJoinProperty, thisAsIShape.StrokeLineJoin);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shapes.Shape.StrokeMiterLimitProperty, thisAsIShape.StrokeMiterLimit);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shapes.Shape.AspectProperty, thisAsIShape.Aspect);


            base.OnUpdate();

            OnEndUpdate();
        }

        partial void OnBeginUpdate();
        partial void OnEndUpdate();


    }


    public static partial class ShapeExtensions
    {
        public static T Fill<T>(this T shape, Microsoft.Maui.Controls.Brush fill) where T : IShape
        {
            shape.Fill = new PropertyValue<Microsoft.Maui.Controls.Brush>(fill);
            return shape;
        }

        public static T Fill<T>(this T shape, Func<Microsoft.Maui.Controls.Brush> fillFunc) where T : IShape
        {
            shape.Fill = new PropertyValue<Microsoft.Maui.Controls.Brush>(fillFunc);
            return shape;
        }



        public static T Stroke<T>(this T shape, Microsoft.Maui.Controls.Brush stroke) where T : IShape
        {
            shape.Stroke = new PropertyValue<Microsoft.Maui.Controls.Brush>(stroke);
            return shape;
        }

        public static T Stroke<T>(this T shape, Func<Microsoft.Maui.Controls.Brush> strokeFunc) where T : IShape
        {
            shape.Stroke = new PropertyValue<Microsoft.Maui.Controls.Brush>(strokeFunc);
            return shape;
        }



        public static T StrokeThickness<T>(this T shape, double strokeThickness, RxDoubleAnimation? customAnimation = null) where T : IShape
        {
            shape.StrokeThickness = new PropertyValue<double>(strokeThickness);
            shape.AppendAnimatable(Microsoft.Maui.Controls.Shapes.Shape.StrokeThicknessProperty, customAnimation ?? new RxDoubleAnimation(strokeThickness), v => shape.StrokeThickness = new PropertyValue<double>(v.CurrentValue()));
            return shape;
        }

        public static T StrokeThickness<T>(this T shape, Func<double> strokeThicknessFunc) where T : IShape
        {
            shape.StrokeThickness = new PropertyValue<double>(strokeThicknessFunc);
            return shape;
        }



        public static T StrokeDashArray<T>(this T shape, Microsoft.Maui.Controls.DoubleCollection strokeDashArray) where T : IShape
        {
            shape.StrokeDashArray = new PropertyValue<Microsoft.Maui.Controls.DoubleCollection>(strokeDashArray);
            return shape;
        }

        public static T StrokeDashArray<T>(this T shape, Func<Microsoft.Maui.Controls.DoubleCollection> strokeDashArrayFunc) where T : IShape
        {
            shape.StrokeDashArray = new PropertyValue<Microsoft.Maui.Controls.DoubleCollection>(strokeDashArrayFunc);
            return shape;
        }



        public static T StrokeDashOffset<T>(this T shape, double strokeDashOffset, RxDoubleAnimation? customAnimation = null) where T : IShape
        {
            shape.StrokeDashOffset = new PropertyValue<double>(strokeDashOffset);
            shape.AppendAnimatable(Microsoft.Maui.Controls.Shapes.Shape.StrokeDashOffsetProperty, customAnimation ?? new RxDoubleAnimation(strokeDashOffset), v => shape.StrokeDashOffset = new PropertyValue<double>(v.CurrentValue()));
            return shape;
        }

        public static T StrokeDashOffset<T>(this T shape, Func<double> strokeDashOffsetFunc) where T : IShape
        {
            shape.StrokeDashOffset = new PropertyValue<double>(strokeDashOffsetFunc);
            return shape;
        }



        public static T StrokeLineCap<T>(this T shape, Microsoft.Maui.Controls.Shapes.PenLineCap strokeLineCap) where T : IShape
        {
            shape.StrokeLineCap = new PropertyValue<Microsoft.Maui.Controls.Shapes.PenLineCap>(strokeLineCap);
            return shape;
        }

        public static T StrokeLineCap<T>(this T shape, Func<Microsoft.Maui.Controls.Shapes.PenLineCap> strokeLineCapFunc) where T : IShape
        {
            shape.StrokeLineCap = new PropertyValue<Microsoft.Maui.Controls.Shapes.PenLineCap>(strokeLineCapFunc);
            return shape;
        }



        public static T StrokeLineJoin<T>(this T shape, Microsoft.Maui.Controls.Shapes.PenLineJoin strokeLineJoin) where T : IShape
        {
            shape.StrokeLineJoin = new PropertyValue<Microsoft.Maui.Controls.Shapes.PenLineJoin>(strokeLineJoin);
            return shape;
        }

        public static T StrokeLineJoin<T>(this T shape, Func<Microsoft.Maui.Controls.Shapes.PenLineJoin> strokeLineJoinFunc) where T : IShape
        {
            shape.StrokeLineJoin = new PropertyValue<Microsoft.Maui.Controls.Shapes.PenLineJoin>(strokeLineJoinFunc);
            return shape;
        }



        public static T StrokeMiterLimit<T>(this T shape, double strokeMiterLimit, RxDoubleAnimation? customAnimation = null) where T : IShape
        {
            shape.StrokeMiterLimit = new PropertyValue<double>(strokeMiterLimit);
            shape.AppendAnimatable(Microsoft.Maui.Controls.Shapes.Shape.StrokeMiterLimitProperty, customAnimation ?? new RxDoubleAnimation(strokeMiterLimit), v => shape.StrokeMiterLimit = new PropertyValue<double>(v.CurrentValue()));
            return shape;
        }

        public static T StrokeMiterLimit<T>(this T shape, Func<double> strokeMiterLimitFunc) where T : IShape
        {
            shape.StrokeMiterLimit = new PropertyValue<double>(strokeMiterLimitFunc);
            return shape;
        }



        public static T Aspect<T>(this T shape, Microsoft.Maui.Controls.Stretch aspect) where T : IShape
        {
            shape.Aspect = new PropertyValue<Microsoft.Maui.Controls.Stretch>(aspect);
            return shape;
        }

        public static T Aspect<T>(this T shape, Func<Microsoft.Maui.Controls.Stretch> aspectFunc) where T : IShape
        {
            shape.Aspect = new PropertyValue<Microsoft.Maui.Controls.Stretch>(aspectFunc);
            return shape;
        }




    }
}