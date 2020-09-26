using GameSearchAppXamarin.Models;
using GameSearchAppXamarin.Services;
using GameSearchAppXamarin.ViewModels;
using System;
using Xamarin.Forms;

namespace GameSearchAppXamarin.ViewModel
{
    class InfoGameViewModel : ViewModelBase
    {
        [Obsolete]
        public InfoGameViewModel()
        {
            ShareGameItemCommand = new Command(ShareGameItem);
            UnLikeGameItemCommand = new Command(LikeUnLikeGameItem);
            WebsiteGameItemCommand = new Command(WebsiteGameItem);
        }

        public Command ShareGameItemCommand { get; set; }
        public Command WebsiteGameItemCommand { get; set; }
        public Command UnLikeGameItemCommand { get; set; }

        private GameDetails _gameDetails;
        public GameDetails GameDetails
        {
            get => _gameDetails;
            set => Set(ref _gameDetails, value);
        }

        public async void InitializeComponent(GameShortDetails gameShortDetails)
        {
            var _gameApiClient = DependencyService.Get<IGameApiClient>();
            var TempGameDetails = await _gameApiClient.GetGameResultByIDAsync<GameDetails>(gameShortDetails.GameID);
            TempGameDetails.LikeTextLabel = gameShortDetails.LikeTextLabel;
            TempGameDetails.IsLiked = gameShortDetails.IsLiked;
            GameDetails = TempGameDetails;
        }
        void LikeUnLikeGameItem()
        {
            if (GameDetails.IsLiked)
                DependencyService.Get<LikedGameViewModel>().UnLikeGameItem(GameDetails);
            else
                DependencyService.Get<LikedGameViewModel>().AddLikedGame(GameDetails);
        }
        void ShareGameItem()
        {
            DependencyService.Get<IShareClient>().ShareUri(GameDetails.Website);
        }

        [Obsolete]
        void WebsiteGameItem()
        {
            Device.OpenUri(new Uri(GameDetails.Website));
        }
    }
}
