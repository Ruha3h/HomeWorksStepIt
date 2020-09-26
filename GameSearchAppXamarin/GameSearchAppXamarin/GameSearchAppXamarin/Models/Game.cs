using GameSearchAppXamarin.Resources;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GameSearchAppXamarin.Models
{
    public class GameResult
    {
        [JsonProperty("count")]
        public int GamesCount { get; set; }

        [JsonProperty("next")]
        public string NextListOfGamesApi { get; set; }

        [JsonProperty("previous")]
        public string PreviousListOfGamesApi { get; set; }

        [JsonProperty("results")]
        public GameShortDetails[] Games { get; set; }

        [JsonProperty("seo_title")]
        public string TitleOfRequest { get; set; }

    }
    public class GamePreview : Property
    {
        public GamePreview()
        {
            ChangeLiked(false);
        }

        public void ChangeLiked(bool liked)
        {
            if (liked)
                LikeTextLabel = LanguageResource.GameItemUnlike;
            else
                LikeTextLabel = LanguageResource.GameItemLike;
            IsLiked = liked;
        }

        [JsonProperty("id")]
        public int GameID { get; set; }

        public bool IsLiked;

        private string _likeTextLabel;
        public string LikeTextLabel
        {
            get => _likeTextLabel;
            set => Set(ref _likeTextLabel, value);
        }
    }
    public class GameShortDetails : GamePreview
    {
        [JsonProperty("name")]
        public string GameName { get; set; }

        [JsonProperty("released")]
        public string ReleasedTime { get; set; }

        [JsonProperty("background_image")]
        public string ImageURL { get; set; }

        [JsonProperty("rating")]
        public string GameRating { get; set; }

    }
    public class GameDetails : GameShortDetails
    {
        [JsonProperty("genres")]
        public Genre[] Genres { get; set; }

        [JsonProperty("stores")]
        public Stores[] Stores { get; set; }

        [JsonProperty("tags")]
        public Tag[] Tags { get; set; }

        [JsonProperty("description_raw")]
        public string Description { get; set; }

        [JsonProperty("updated")]
        public string LastUpdatedTime { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

    }
    public class Genre
    {
        [JsonProperty("id")]
        public int GenreID { get; set; }

        [JsonProperty("name")]
        public string GenreName { get; set; }

        [JsonProperty("image_background")]
        public string ImageURL { get; set; }
    }
    public class Stores
    {
        [JsonProperty("id")]
        public int StoresID { get; set; }

        [JsonProperty("store")]
        public Store Info { get; set; }

        [JsonProperty("url_en")]
        public string EnURL { get; set; }

        [JsonProperty("url_ru")]
        public string RuURL { get; set; }
    }
    public class Store
    {
        [JsonProperty("id")]
        public int StoreID { get; set; }

        [JsonProperty("name")]
        public string StoreName { get; set; }

        [JsonProperty("domain")]
        public string DomainSiteURL { get; set; }

    }
    public class Tag
    {
        [JsonProperty("id")]
        public int TagID { get; set; }

        [JsonProperty("name")]
        public string TagName { get; set; }

        [JsonProperty("image_background")]
        public string image_background { get; set; }
    }

}
