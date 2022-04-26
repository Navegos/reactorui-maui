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
    public partial interface IGenericItemsView : IView
    {


    }

    public abstract partial class ItemsView<T, TChild> : View<T>, IGenericItemsView where T : Microsoft.Maui.Controls.ItemsView<TChild>, new() where TChild : Microsoft.Maui.Controls.BindableObject
    {
        public ItemsView()
        {

        }

        public ItemsView(Action<T?> componentRefAction)
            : base(componentRefAction)
        {

        }



        protected override void OnUpdate()
        {
            OnBeginUpdate();

            base.OnUpdate();

            OnEndUpdate();
        }


        partial void OnBeginUpdate();
        partial void OnEndUpdate();


    }


    public static partial class ItemsViewExtensions
    {

    }
}