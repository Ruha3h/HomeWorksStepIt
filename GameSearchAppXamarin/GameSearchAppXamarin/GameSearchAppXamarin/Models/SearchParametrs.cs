using GameSearchAppXamarin.Services;
using GameSearchAppXamarin.ViewModel;
using GameSearchAppXamarin.Views;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GameSearchAppXamarin.Models
{

    public class QuerryItemsBase
    {
        private QuerryItemsBase() {}
        public static ObservableCollection<QuerryItem> QuerryItems 
        { get;} = new ObservableCollection<QuerryItem>{
                new QueryyGenre(),
                new QueryyPlatform(),
                new QueryyPublishers(),
                new QueryyStores(),
                new QueryyTags()
        };
        public static ObservableCollection<MotherQuerry> motherQuerries;
        public static void LoadItems(ObservableCollection<Querry> querries)
        {
            for (int i = 0; i < querries.Count; i++)
            {
                LoadItem(querries[i], i);
            }
        }
        public static void LoadItem(Querry querryItem , int index)
        {
            if (motherQuerries[index] == null)
            {
                motherQuerries.Add(new MotherQuerry());
            }
            querryItem.SelectedIndex = motherQuerries[index].MotherIndex;
            querryItem.QuerrySelectedItem.SelectedIndex = motherQuerries[index].ChildIndex;
        }
        public static void SaveItems(ObservableCollection<Querry> querries)
        {
            motherQuerries = new ObservableCollection<MotherQuerry>();
            foreach (var item in querries)
            {
                motherQuerries.Add(new MotherQuerry(
                    item.SelectedIndex,
                    item.QuerrySelectedItem.SelectedIndex));
            }
        }
    }
    public class MotherQuerry
    {
        public MotherQuerry(int motherIndex = 0,int childIndex = 0)
        {
            MotherIndex = motherIndex;
            ChildIndex = childIndex;
        }
        public int MotherIndex = 0;
        public int ChildIndex = 0;
    }
    public class Querry : Property
    {
        public Querry()
        {
            TypeItems = QuerryItemsBase.QuerryItems;
        }

        private ObservableCollection<QuerryItem> _typeItems;
        public ObservableCollection<QuerryItem> TypeItems
        {
            get => _typeItems;
            set => Set(ref _typeItems, value);
        }

        private QuerryItem _querrySelectedItem;
        public QuerryItem QuerrySelectedItem
        {
            get => _querrySelectedItem;
            set
            {
                if (value != null)
                    Set(ref _querrySelectedItem, value);
            }
        }

        private int _selectedIndex;
        public int SelectedIndex
        {
            get => _selectedIndex;
            set => Set(ref _selectedIndex, value);
        }
    }
    public class QuerryItem : Property
    {
        public QuerryItem(string querryName , string querryCode)
        {
            QuerryName = querryName;
            QuerryCode = querryCode;
        }

        private ObservableCollection<string> _items;
        public ObservableCollection<string> Items
        {
            get => _items;
            set => Set(ref _items, value);
        }

        private int _selectedIndex;
        public int SelectedIndex
        {
            get => _selectedIndex;
            set => Set(ref _selectedIndex, value);
        }

        public string QuerryName;
        public string QuerryCode;
        public override string ToString()
        {
            return QuerryName;
        }
        public string ToQuerryCode()
        {
            return QuerryCode;
        }
    }
    public class QueryyGenre : QuerryItem
    {
        public QueryyGenre() : base(nameof(QueryyGenre),"genres")
        {
            InitializeComponent();
        }
        async void InitializeComponent()
        {
            var Genres = (await DependencyService.Get<IGameApiClient>()
                .GetGenreResultAsync()).Games;
            var Temp = new ObservableCollection<string>();
            foreach (var item in Genres)
            {
                Temp.Add(item.GameName);
            }
            Items = Temp;
        }
    }
    public class QueryyPlatform : QuerryItem
    {
        public QueryyPlatform() : base(nameof(QueryyPlatform), "platforms")
        {
            InitializeComponent();
        }
        async void InitializeComponent()
        {
            var Genres = (await DependencyService.Get<IGameApiClient>()
                .GetPlatformResultAsync()).Games;
            var Temp = new ObservableCollection<string>();
            foreach (var item in Genres)
            {
                Temp.Add(item.GameName);
            }
            Items = Temp;
        }
    }
    public class QueryyPublishers : QuerryItem
    {
        public QueryyPublishers() : base(nameof(QueryyPublishers), "publishers")
        {
            InitializeComponent();
        }
        async void InitializeComponent()
        {
            var Genres = (await DependencyService.Get<IGameApiClient>()
                .GetPublisherResultAsync()).Games;
            var Temp = new ObservableCollection<string>();
            foreach (var item in Genres)
            {
                Temp.Add(item.GameName);
            }
            Items = Temp;
        }
    }
    public class QueryyStores : QuerryItem
    {
        public QueryyStores() : base(nameof(QueryyStores), "stores")
        {
            InitializeComponent();
        }
        async void InitializeComponent()
        {
            var Genres = (await DependencyService.Get<IGameApiClient>()
                .GetStoreResultAsync()).Games;
            var Temp = new ObservableCollection<string>();
            foreach (var item in Genres)
            {
                Temp.Add(item.GameName);
            }
            Items = Temp;
        }
    }
    public class QueryyTags : QuerryItem
    {
        public QueryyTags() : base(nameof(QueryyTags), "tags")
        {
            InitializeComponent();
        }
        async void InitializeComponent()
        {
            var Genres = (await DependencyService.Get<IGameApiClient>()
                .GetTagResultAsync()).Games;
            var Temp = new ObservableCollection<string>();
            foreach (var item in Genres)
            {
                Temp.Add(item.GameName);
            }
            Items = Temp;
        }
    }                                                                                                                                                                                                                                                                                                           
}    

