using GameSearchAppXamarin.Models;
using GameSearchAppXamarin.Services;
using GameSearchAppXamarin.ViewModel;
using GameSearchAppXamarin.Views;
using System.Globalization;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace GameSearchAppXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<IGameApiClient, GameApiClient>();
            DependencyService.Register<IShareClient, ShareClient>();

            DependencyService.Register<Querry>();

            DependencyService.Register<MainPage>();

            DependencyService.Register<MainMenuPage>();
            DependencyService.Register<MainMenuViewModel>();

            DependencyService.Register<GamePage>();
            DependencyService.Register<GameViewModel>();

            DependencyService.Register<OptionsSearchPage>();
            DependencyService.Register<OptionSearchViewModel>();

            DependencyService.Register<LikedGamePage>();
            DependencyService.Register<LikedGameViewModel>();

            DependencyService.Register<SettingsPage>();
            DependencyService.Register<SettingViewModel>();

            DependencyService.Register<InfoGamePage>();
            DependencyService.Register<InfoGameViewModel>();

            var themeID = Preferences.Get("theme", AppTheme.LightTheme);
            DependencyService.Get<SettingViewModel>().SetTheme(themeID, false);

            var langCode = Preferences.Get("language", CultureInfo.CurrentUICulture.Name);
            CultureInfo.CurrentUICulture = new CultureInfo(langCode);

            MainPage = DependencyService.Get<MainPage>();
        }

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {

        }

        protected override void OnResume()
        {
        }


    }
}