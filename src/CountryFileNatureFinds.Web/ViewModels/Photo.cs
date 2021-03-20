using System;

namespace CountryFileNatureFinds.Web.ViewModels
{
    public class Photo
    {
        public string Link { get; set; }
        public string Photographer { get; set; }
        public string FormattedLink() => $"data/spring2021-showcase/{Link}";
    }
}