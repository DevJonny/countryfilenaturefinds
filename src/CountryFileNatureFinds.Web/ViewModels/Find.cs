using System.Collections.Generic;
using System.Linq;

namespace CountryFileNatureFinds.Web.ViewModels
{
    public record Find
    {
        public string Name { get; }
        public string Description { get; }
        public List<Image> Images { get; }
        public string FirstImageUri => $"https://localhost:5001/{Images.FirstOrDefault()?.Link}";

        public Find(string name, string description, List<Image> images)
            => (Name, Description, Images)
                = (name, description, images);
    }
}