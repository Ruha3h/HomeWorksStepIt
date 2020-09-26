using GameSearchAppXamarin.Models;
using GameSearchAppXamarin.Services;
using GameSearchAppXamarin.ViewModels;
using GameSearchAppXamarin.Views;
using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace GameSearchAppXamarin.ViewModel
{
    class LikedGameViewModel : ViewModelBase
    {
        public LikedGameViewModel()
        {
            ViewGameItemCommand = new Command<GameShortDetails>(ViewGameItem);
            UnLikeGameItemCommand = new Command<GameShortDetails>(UnLikeGameItem);
        }
        public Command<GameShortDetails> ViewGameItemCommand { get; set; }
        public Command<GameShortDetails> UnLikeGameItemCommand { get; set; }

        private ObservableCollection<GameShortDetails> _likedGamesItems;
        public ObservableCollection<GameShortDetails> LikedGamesItems
        {
            get => _likedGamesItems;
            set => Set(ref _likedGamesItems, value);
        }

        void ViewGameItem(GameShortDetails gameShortDetails)
        {
            DependencyService.Get<MainPage>().Detail.Navigation.PushAsync(new InfoGamePage(gameShortDetails));
        }
        public void UnLikeGameItem(GameShortDetails gameShortDetails)
        {
            if (IsHaveItem(gameShortDetails.GameID))
            {
                gameShortDetails.ChangeLiked(false);
                var gameId = gameShortDetails.GameID;
                LikedGamesItems.Remove(LikedGamesItems.Where(x => x.GameID == gameId).ElementAt(0));
                Save();
            }
        }
        public void AddLikedGame(GameShortDetails gameShortDetails)
        {
            if (!IsHaveItem(gameShortDetails.GameID))
            {
                gameShortDetails.ChangeLiked(true);
                var Temp = LikedGamesItems;
                Temp.Add(gameShortDetails);
                LikedGamesItems = Temp;
                Save();
            }
        }
     
        private void Save()
        {
            var LikedGamesID = JsonConvert.SerializeObject(new ObservableCollection<int>(LikedGamesItems.Select(x => x.GameID)));
            Preferences.Set("liked_games_preview", LikedGamesID);
        }

        public async Task<bool> LoadAsync(ObservableCollection<int> LikedGameID)
        {
            var TempLikedGame = new ObservableCollection<GameShortDetails>();
            IGameApiClient _gameApiClient = DependencyService.Get<IGameApiClient>();
            foreach (var item in LikedGameID)
            {
                TempLikedGame.Add(await _gameApiClient.GetGameResultByIDAsync<GameShortDetails>(item));
            }
            LikedGamesItems = TempLikedGame;
            return true;
        }

        public bool IsHaveItem(int gameID)
        {
            return LikedGamesItems.Any(x => x.GameID == gameID);
        }
    }
}
