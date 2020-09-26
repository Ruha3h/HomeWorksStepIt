using Xamarin.Forms;

namespace GameSearchAppXamarin.Models
{
    public class SquareView : ContentView
    {
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            HeightRequest = width;
        }
    }
}
