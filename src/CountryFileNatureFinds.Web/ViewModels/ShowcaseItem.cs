using System.Collections.Generic;

namespace CountryFileNatureFinds.Web.ViewModels
{
    public class ShowcaseItem
    {
        public string Name { get; set; }
        public List<Photo> Photos { get; set; }
    }

    public class Photo
    {
        public string Link { get; set; }
        public string Photographer { get; set; }
        public string FormattedLink => $"countryfilenaturefinds/data/spring2021-showcase/{Link}";
    }
}