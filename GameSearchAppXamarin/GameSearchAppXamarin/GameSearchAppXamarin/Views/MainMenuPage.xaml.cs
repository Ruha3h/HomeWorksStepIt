using GameSearchAppXamarin.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GameSearchAppXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMenuPage : ContentPage
    {
        public ListView MenuListView => menuListView;
        public MainMenuPage()
        {
            InitializeComponent();
            BindingContext = DependencyService.Get<MainMenuViewModel>();
        }

    }
}