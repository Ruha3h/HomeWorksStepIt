using GameSearchAppXamarin.Models;
using GameSearchAppXamarin.Resources;
using GameSearchAppXamarin.Services;
using GameSearchAppXamarin.ViewModels;
using Resources;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace GameSearchAppXamarin.ViewModel
{
    class SettingViewModel : ViewModelBase
    {
        public SettingViewModel()
        {
            ThemesItems = new ObservableCollection<AppTheme>
            {
                new AppTheme {Index = AppTheme.LightTheme, Title = LanguageResource.SettingLightTheme},
                new AppTheme {Index = AppTheme.DarkTheme , Title = LanguageResource.SettingDarkTheme}
            };
            Console.WriteLine(ThemesItems[0].Title);
            SelectThemeCommand = new Command(SelectTheme);
            var themeID = Preferences.Get("theme", AppTheme.LightTheme);
            CurrentTheme = ThemesItems[themeID];

            Languages = new ObservableCollection<Language>
            {
                new Language {Index = 0,Title = "English", Code = "en"},
                new Language {Index = 1,Title = "Русский", Code = "ru"},
            };
            SelectLanguageCommand = new Command(SelectLanguage);
            var langId = Preferences.Get("languageID", 0);
            CurrentLanguage = Languages[langId];
        }

        private ObservableCollection<AppTheme> _themesItems;
        public ObservableCollection<AppTheme> ThemesItems
        {
            get => _themesItems;
            set => Set(ref _themesItems, value);
        }

        private ObservableCollection<Language> _languages;
        public ObservableCollection<Language> Languages
        {
            get => _languages;
            set => Set(ref _languages, value);
        }

        private Language _currentLanguage;
        public Language CurrentLanguage
        {
            get => _currentLanguage;
            set => Set(ref _currentLanguage, value);
        }

        private AppTheme _currentTheme;
        public AppTheme CurrentTheme
        {
            get => _currentTheme;
            set => Set(ref _currentTheme, value);
        }


        public Command SelectLanguageCommand { get; set; }
        public Command SelectThemeCommand { get; set; }

        private void SelectLanguage()
        {
            CultureInfo.CurrentUICulture = new CultureInfo(CurrentLanguage.Code);

            Preferences.Set("language", CurrentLanguage.Code);
            Preferences.Set("languageID", CurrentLanguage.Index);
        }
        private void SelectTheme()
        {
            SetTheme(CurrentTheme.Index);
        }
        public void SetTheme(int index, bool needSet = true)
        {
            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            if (mergedDictionaries != null)
            {
                mergedDictionaries.Clear();
                var statusBarStyleManager = DependencyService.Get<IStatusBarStyleManager>();
                if (index == AppTheme.LightTheme)
                {
                    mergedDictionaries.Add(new LightTheme());
                    statusBarStyleManager.SetLightTheme((Color)App.Current.Resources["PageMainStatusBarColor"]);
                }
                else if (index == AppTheme.DarkTheme)
                {
                    mergedDictionaries.Add(new DarkTheme());
                    statusBarStyleManager.SetDarkTheme((Color)App.Current.Resources["PageMainStatusBarColor"]);
                }
                if (needSet) Preferences.Set("theme", index);
                DependencyService.Get<MainMenuViewModel>().ReInitItems();
            }
        }

    }
}
