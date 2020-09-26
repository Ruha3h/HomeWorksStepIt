using GameSearchAppXamarin.Models;
using GameSearchAppXamarin.Views;
using System.ComponentModel;
using Xamarin.Forms;

namespace GameSearchAppXamarin
{
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            MasterPage.MenuListView.ItemSelected += MenuListViewOnItemSelected;
        }

        public void MenuListViewOnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is MainMenuItem mainMenuItem)
            {
                NavigationPage page;
                if (mainMenuItem.PageType == typeof(SettingsPage))
                    page = new NavigationPage(DependencyService.Get<SettingsPage>());
                else if (mainMenuItem.PageType == typeof(LikedGamePage))
                    page = new NavigationPage(DependencyService.Get<LikedGamePage>());
                else if (mainMenuItem.PageType == typeof(OptionsSearchPage))
                    page = new NavigationPage(DependencyService.Get<OptionsSearchPage>());
                else
                    page = new NavigationPage(DependencyService.Get<GamePage>());
                Detail = page;
                IsPresented = false;
                MasterPage.MenuListView.SelectedItem = null;
            }
        }

        public void CloseMaster()
        {
            IsPresented = false;
        }
    }
}