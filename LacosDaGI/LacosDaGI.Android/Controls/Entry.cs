using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer (typeof(LacosDaGI.Controls.Entry), typeof(LacosDaGI.Droid.Controls.Entry))]
namespace LacosDaGI.Droid.Controls
{
    public class Entry : EntryRenderer
    {
        public Entry(Context context) : base(context)
        {

        }

        public LacosDaGI.Controls.Entry CustomEntry => (LacosDaGI.Controls.Entry)Element;
        protected override FormsEditText CreateNativeControl()
        {
            var control = base.CreateNativeControl();
            UpdateBackground();

            return control;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Entry> e)
        {
            base.OnElementChanged(e);
            UpdateBackground();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == LacosDaGI.Controls.Entry.CornerRadiusProperty.PropertyName)
                UpdateBackground();
            else if (e.PropertyName == LacosDaGI.Controls.Entry.BorderThicknessProperty.PropertyName)
                UpdateBackground();
            else if (e.PropertyName == LacosDaGI.Controls.Entry.BorderColorProperty.PropertyName)
                UpdateBackground();

            base.OnElementPropertyChanged(sender, e);
        }

        protected override void UpdateBackgroundColor()
        {
            UpdateBackground();
        }

        protected void UpdateBackground(FormsEditText control)
        {
            if (control == null) return;

            var gd = new GradientDrawable();
            gd.SetColor(Element.BackgroundColor.ToAndroid());
            gd.SetCornerRadius(Context.ToPixels(CustomEntry.CornerRadius));
            gd.SetStroke((int)Context.ToPixels(CustomEntry.BorderThickness), CustomEntry.BorderColor.ToAndroid());
            control.SetBackground(gd);

            var padTop = (int)Context.ToPixels(CustomEntry.Padding.Top);
            var padBottom = (int)Context.ToPixels(CustomEntry.Padding.Bottom);
            var padLeft = (int)Context.ToPixels(CustomEntry.Padding.Left);
            var padRight = (int)Context.ToPixels(CustomEntry.Padding.Right);

            control.SetPadding(padLeft, padTop, padRight, padBottom);
        }

        protected void UpdateBackground()
        {
            UpdateBackground(Control);
        }
    }
}