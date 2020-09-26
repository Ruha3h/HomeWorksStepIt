using GameSearchAppXamarin.Models;
using GameSearchAppXamarin.ViewModels;
using GameSearchAppXamarin.Views;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace GameSearchAppXamarin.ViewModel
{
    class OptionSearchViewModel : ViewModelBase
    {
        public OptionSearchViewModel()
        {
            QueryItems = new ObservableCollection<Querry>();
            DeleteItemCommand = new Command<Querry>(DeleteItem);
            AddItemCommand = new Command(AddItem);
            CancelCommand = new Command(ClosePage);
            AcceptCommand = new Command(Accept);
        }

        private ObservableCollection<Querry> _queryItems;
        public ObservableCollection<Querry> QueryItems
        {
            get => _queryItems;
            set
            {
                Set(ref _queryItems, value);
                QuerryItemsBase.LoadItems(QueryItems);
            }
        }

        public Command<Querry> DeleteItemCommand { get; set; }
        public Command AddItemCommand { get; set; }
        public Command CancelCommand { get; set; }
        public Command AcceptCommand { get; set; }

        void DeleteItem(Querry querry)
        {
            QueryItems.Remove(querry);
        }

        void AddItem()
        {
            QueryItems.Add(new Querry());
        }

        void Accept()
        {
            QuerryItemsBase.SaveItems(QueryItems);
            ClosePage();
        }

        void ClosePage()
        {
            DependencyService.Get<MainPage>().Detail.Navigation.PopAsync();
        }

    }
}
