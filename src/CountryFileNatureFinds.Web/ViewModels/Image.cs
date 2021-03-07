namespace CountryFileNatureFinds.Web.ViewModels
{
    public record Image
    {
        public string Name { get; init; }
        public string Link { get; init; }

        public Image(string name, string link)
            => (Name, Link)
                = (name, link);
    }
}