using GameSearchAppXamarin.Models;
using GameSearchAppXamarin.Resources;
using GameSearchAppXamarin.ViewModels;
using GameSearchAppXamarin.Views;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace GameSearchAppXamarin.ViewModel
{
    class MainMenuViewModel : ViewModelBase
    {
        public MainMenuViewModel()
        {
            NavigationHeight = 50;
            ReInitItems();
            GoBackImageCommand = new Command(GoBackPage);
        }

        public Command GoBackImageCommand { get; set; }

        void GoBackPage()
        {
            DependencyService.Get<MainPage>().CloseMaster();
        }

        private ObservableCollection<MainMenuItem> _menuItems;
        public ObservableCollection<MainMenuItem> MenuItems
        {
            get => _menuItems;
            set => Set(ref _menuItems, value);
        }

        private double _navigationHeight;
        public double NavigationHeight
        {
            get => _navigationHeight;
            set => Set(ref _navigationHeight, value);
        }


        public void ReInitItems()
        {
            MenuItems = new ObservableCollection<MainMenuItem>
            {
                new MainMenuItem { Title = LanguageResource.MenuGameLabel           ,Image = (string)App.Current.Resources["PageGameImagePath"]          ,PageType = typeof(GamePage) },
                new MainMenuItem { Title = LanguageResource.MenuLikedGameLabel      ,Image = (string)App.Current.Resources["PageLikeImagePath"]          ,PageType = typeof(LikedGamePage) },
                new MainMenuItem { Title = LanguageResource.MenuSettingLabel        ,Image = (string)App.Current.Resources["PageSettingsImagePath"]      ,PageType = typeof(SettingsPage) }
            };
        }
    }
}