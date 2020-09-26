using GameSearchAppXamarin.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GameSearchAppXamarin.ViewModels
{
    class ViewModelBase : Property
    {
        private string _title;
        public string Title
        {
            get => _title;
            set => Set(ref _title, value);
        }
    }
}