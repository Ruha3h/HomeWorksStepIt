using System;

namespace GameSearchAppXamarin.Services
{
    public interface ISearchPage
    {
        void OnSearchBarTextChanged(string text);
        void OnSearchBarTextSubmit(string text);
        event EventHandler<string> SearchBarTextChanged;
        event EventHandler<string> SearchBarTextSubmit;
    }
}
