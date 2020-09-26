using System.Threading.Tasks;

namespace GameSearchAppXamarin.Services
{
    interface IShareClient
    {
        Task ShareText(string text);
        Task ShareUri(string uri);
    }
}