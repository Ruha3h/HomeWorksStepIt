using GameSearchAppXamarin.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GameSearchAppXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OptionsSearchPage : ContentPage
    {
        public OptionsSearchPage()
        {
            InitializeComponent();
            BindingContext = new OptionSearchViewModel();
        }
    }
}