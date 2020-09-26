using System;
using Android.Content;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.Text;
using Android.Util;
using CustomRenderer.Android;
using GameSearchAppXamarin.Models;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Color = Xamarin.Forms.Color;

[assembly: ExportRenderer(typeof(EllipseEntry), typeof(EllipseEntryRenderer))]

namespace CustomRenderer.Android
{
    [Obsolete]
    class EllipseEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                var view = (EllipseEntry) Element;

                var gradientBackground = new GradientDrawable();
                gradientBackground.SetColor(view.BackgroundColor.ToAndroid());
                gradientBackground.SetShape(ShapeType.Rectangle);
                gradientBackground.SetCornerRadius(
                    DpToPixels(this.Context, Convert.ToSingle(view.CornerRadius)));
                
                Control.SetBackground(gradientBackground);
                Control.SetRawInputType(InputTypes.TextFlagNoSuggestions);
                Control.SetHintTextColor(ColorStateList.ValueOf(view.PlaceholderColor.ToAndroid()));
                Control.SetPadding(
                    (int)DpToPixels(this.Context, Convert.ToSingle(10)), Control.Left,
                    (int)DpToPixels(this.Context, Convert.ToSingle(0)), Control.Right);

                view.BackgroundColor = view.MainBackgroundColor;
            }

            float DpToPixels(Context context, float valueInDp)
            {
                DisplayMetrics metrics = context.Resources.DisplayMetrics;
                return TypedValue.ApplyDimension(ComplexUnitType.Dip, valueInDp, metrics);
            }
        }
    }
}