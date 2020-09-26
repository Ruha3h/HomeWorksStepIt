using GameSearchAppXamarin.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GameSearchAppXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
            BindingContext = DependencyService.Get<SettingViewModel>();
        }

    }
}