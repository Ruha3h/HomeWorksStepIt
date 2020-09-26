using GameSearchAppXamarin.Models;
using GameSearchAppXamarin.ViewModel;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinTranslator;

namespace GameSearchAppXamarin.Services
{
    class GameApiClient : IGameApiClient
    {
        private string _apiURL = "https://api.rawg.io/api";
        private string _apiGames = "games";
        private string _apiGenre = "genres";
        private string _apiPlatform = "platforms";
        private string _apiPublisher = "publishers";
        private string _apiStore = "stores";
        private string _apiTag = "tags";
        private readonly HttpClient _httpClient;

        public GameApiClient()
        {
            _httpClient = new HttpClient();
        }
        public async Task<T> GetGameResultByIDAsync<T>(int gameID)
        {
            var uri = new Uri($"{_apiURL}/{_apiGames}/{gameID}");
            var json = await _httpClient.GetStringAsync(uri);
            var result = JsonConvert.DeserializeObject<T>(json);

            return result;
        }
        public async Task<GameResult> GetGameResultAsync()
        {
            var uri = new Uri($"{_apiURL}/{_apiGames}")
                .AddQueryParameter("page_size", "20");
            var json = await _httpClient.GetStringAsync(uri);
            var result = JsonConvert.DeserializeObject<GameResult>(json);

            return result;
        }
        public async Task<GameResult> GetGameResultByNameAsync(string name)
        {
            var querryItems = DependencyService.Get<OptionSearchViewModel>().QueryItems;
            var uri = new Uri($"{_apiURL}/{_apiGames}")
                 .AddQueryParameter("search", name)
                 .AddQueryParameter("page_size", "20");
            //foreach (var item in querryItems)
            //{
            //    uri.AddQueryParameter(item.QuerrySelectedItems.ToQuerryCode(), item.QuerrySelectedItems.SelectedItem);
            //}
            var json = await _httpClient.GetStringAsync(uri);
            var result = JsonConvert.DeserializeObject<GameResult>(json);

            return result;
        }
        public async Task<GameResult> GetGenreResultAsync()
        {
            var uri = new Uri($"{_apiURL}/{_apiGenre}");
            var json = await _httpClient.GetStringAsync(uri);
            var result = JsonConvert.DeserializeObject<GameResult>(json);

            return result;
        }
        public async Task<GameResult> GetPlatformResultAsync()
        {
            var uri = new Uri($"{_apiURL}/{_apiPlatform}");
            var json = await _httpClient.GetStringAsync(uri);
            var result = JsonConvert.DeserializeObject<GameResult>(json);

            return result;
        }
        public async Task<GameResult> GetPublisherResultAsync()
        {
            var uri = new Uri($"{_apiURL}/{_apiPublisher}");
            var json = await _httpClient.GetStringAsync(uri);
            var result = JsonConvert.DeserializeObject<GameResult>(json);

            return result;
        }
        public async Task<GameResult> GetStoreResultAsync()
        {
            var uri = new Uri($"{_apiURL}/{_apiStore}");
            var json = await _httpClient.GetStringAsync(uri);
            var result = JsonConvert.DeserializeObject<GameResult>(json);

            return result;
        }
        public async Task<GameResult> GetTagResultAsync()
        {
            var uri = new Uri($"{_apiURL}/{_apiTag}");
            var json = await _httpClient.GetStringAsync(uri);
            var result = JsonConvert.DeserializeObject<GameResult>(json);

            return result;
        }

    }
}
