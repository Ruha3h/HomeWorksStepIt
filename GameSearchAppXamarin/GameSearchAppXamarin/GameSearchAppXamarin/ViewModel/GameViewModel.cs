using GameSearchAppXamarin.Models;
using GameSearchAppXamarin.Services;
using GameSearchAppXamarin.ViewModels;
using GameSearchAppXamarin.Views;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace GameSearchAppXamarin.ViewModel
{
    class GameViewModel : ViewModelBase
    {
        private IGameApiClient _gameApiClient;
        private OptionsSearchPage _optionsSearchPage;
         
        public GameViewModel()
        {
            _gameApiClient = DependencyService.Get<IGameApiClient>();
            _optionsSearchPage = DependencyService.Get<OptionsSearchPage>();

            OptionsSearchCommand = new Command(OpenSearchOptions);
            ViewGameItemCommand = new Command<GameShortDetails>(ViewGameItem);
            LikeGameItemCommand = new Command<GameShortDetails>(LikeUnLikeGameItem);

            InitializeComponent();
        }

        async void InitializeComponent()
        {
            var tempStart = JsonConvert.SerializeObject(new ObservableCollection<int>());
            var LikedGamesID = JsonConvert.DeserializeObject<ObservableCollection<int>>(Preferences.Get("liked_games_preview", tempStart));
            var page = DependencyService.Get<LikedGameViewModel>();
            await page.LoadAsync(LikedGamesID);
            SetItems(new ObservableCollection<GameShortDetails>((await _gameApiClient.GetGameResultAsync()).Games));
        }

        public async void SetItems(string searchText)
        {
            SetItems(new ObservableCollection<GameShortDetails>((await _gameApiClient.GetGameResultByNameAsync(searchText)).Games));
        }

        public void SetItems(ObservableCollection<GameShortDetails> gameShortDetails)
        {
            var page = DependencyService.Get<LikedGameViewModel>();
            var games = gameShortDetails;
            foreach (var item in games)
            {
                if (page.IsHaveItem(item.GameID))
                {
                    item.ChangeLiked(true);
                }
            }
            GamesItems = games;
        }

        public Command OptionsSearchCommand { get; set; }
        public Command<GameShortDetails> ViewGameItemCommand { get; set; }
        public Command<GameShortDetails> LikeGameItemCommand { get; set; }

        void OpenSearchOptions()
        {
            DependencyService.Get<MainPage>().Detail.Navigation.PushAsync(_optionsSearchPage);
        }
        void LikeUnLikeGameItem(GameShortDetails gameShortDetails)
        {
            if (gameShortDetails.IsLiked)
                DependencyService.Get<LikedGameViewModel>().UnLikeGameItem(gameShortDetails);
            else
                DependencyService.Get<LikedGameViewModel>().AddLikedGame(gameShortDetails);
        }
        void ViewGameItem(GameShortDetails gameShortDetails)
        {
            DependencyService.Get<MainPage>().Detail.Navigation.PushAsync(new InfoGamePage(gameShortDetails));
        }

        private ObservableCollection<GameShortDetails> _gamesItems;
        public ObservableCollection<GameShortDetails> GamesItems
        {
            get => _gamesItems;
            set => Set(ref _gamesItems, value);
        }
    }
}
