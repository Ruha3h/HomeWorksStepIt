using GameSearchAppXamarin.Models;
using System.Threading.Tasks;

namespace GameSearchAppXamarin.Services
{
    interface IGameApiClient
    {
        Task<GameResult> GetGameResultAsync();
        Task<GameResult> GetGameResultByNameAsync(string name);
        Task<GameResult> GetGenreResultAsync();
        Task<GameResult> GetPlatformResultAsync();
        Task<GameResult> GetPublisherResultAsync();
        Task<GameResult> GetStoreResultAsync();
        Task<GameResult> GetTagResultAsync();
        Task<T> GetGameResultByIDAsync<T>(int gameID);
    }
}
