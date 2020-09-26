using GameSearchAppXamarin.Models;
using GameSearchAppXamarin.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GameSearchAppXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoGamePage : ContentPage
    {
        public InfoGamePage()
        {
            InitializeComponent();
            BindingContext = DependencyService.Get<InfoGameViewModel>();
        }

        public InfoGamePage(GameShortDetails gameShortDetails) : this()
        {
            (BindingContext as InfoGameViewModel)?.InitializeComponent(gameShortDetails);
        }
    }
}