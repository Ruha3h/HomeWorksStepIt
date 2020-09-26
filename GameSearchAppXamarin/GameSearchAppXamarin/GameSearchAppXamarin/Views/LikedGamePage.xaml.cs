using GameSearchAppXamarin.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GameSearchAppXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LikedGamePage : ContentPage
    {
        public LikedGamePage()
        {
            InitializeComponent();
            BindingContext = DependencyService.Get<LikedGameViewModel>();
        }
    }
}