using System;
using Xamarin.Forms;

namespace GameSearchAppXamarin.Models
{
    public class EllipseEntry : Entry
    {

        public bool IsCurvedCornersEnabled
        {
            get => (bool)GetValue(IsCurvedCornersEnabledProperty);
            set => SetValue(IsCurvedCornersEnabledProperty, value);
        }
        public static readonly BindableProperty IsCurvedCornersEnabledProperty =
            BindableProperty.Create(
                nameof(IsCurvedCornersEnabled),
                typeof(bool),
                typeof(EllipseEntry),
                true);

        public double CornerRadius
        {
            get => (double)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }
        [Obsolete]
        public static readonly BindableProperty CornerRadiusProperty =
            BindableProperty.Create(
                nameof(CornerRadius),
                typeof(double),
                typeof(EllipseEntry),
                Device.OnPlatform<double>(6, 7, 7));

        public Color MainBackgroundColor
        {
            get => (Color)GetValue(MainBackgroundColorProperty);
            set => SetValue(MainBackgroundColorProperty, value);
        }
        public static readonly BindableProperty MainBackgroundColorProperty =
            BindableProperty.Create(
                nameof(MainBackgroundColor),
                typeof(Color),
                typeof(EllipseEntry),
                Color.White);

    }
}
