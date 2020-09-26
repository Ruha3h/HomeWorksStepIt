using GameSearchAppXamarin.Models;
using GameSearchAppXamarin.Services;
using GameSearchAppXamarin.ViewModel;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GameSearchAppXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GamePage : ContentPage, ISearchPage
    {
        private IGameApiClient _gameApiClient;
        public GamePage()
        {
            InitializeComponent();
            _gameApiClient = DependencyService.Get<IGameApiClient>();
            BindingContext = DependencyService.Get<GameViewModel>();
            SearchBarTextChanged += HandleSearchBarTextChanged;
            SearchBarTextSubmit += HandleSearchBarTextSubmit;
        }

        public event EventHandler<string> SearchBarTextChanged;
        public event EventHandler<string> SearchBarTextSubmit;

        public void OnSearchBarTextChanged(string text) => SearchBarTextChanged?.Invoke(this, text);
        public void OnSearchBarTextSubmit(string text) => SearchBarTextSubmit?.Invoke(this, text);

        void HandleSearchBarTextSubmit(object sender, string searchBarText)
        {
            DependencyService.Get<GameViewModel>().SetItems(searchBarText);
        }

        void HandleSearchBarTextChanged(object sender, string searchBarText)
        {
            
        }


    }
}