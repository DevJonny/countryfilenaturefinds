using System.Text.Json;

namespace CountryFileNatureFinds.Web
{
    public static class SerializerExtensions
    {
        public static T Deserialise<T>(this string json)
        {
            return JsonSerializer.Deserialize<T>(json, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
        }
    }
}