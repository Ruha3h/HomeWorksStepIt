namespace GameSearchAppXamarin.Models
{
    class Language
    {
        public string Title { get; set; }
        public string Code { get; set; }
        public int Index { get; set; }

        public override string ToString() => Title;
    }
}
