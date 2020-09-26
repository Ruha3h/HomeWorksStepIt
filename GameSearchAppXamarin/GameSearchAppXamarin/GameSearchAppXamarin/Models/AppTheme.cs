namespace GameSearchAppXamarin.Models
{
    class AppTheme
    {
        public string Title { get; set; }
        public int Index { get; set; }
        public static int LightTheme = 0;
        public static int DarkTheme = 1;
        public override string ToString()
        {
            return Title;
        }
    }
}
