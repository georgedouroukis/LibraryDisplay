using Newtonsoft.Json;

namespace LibraryDisplay.Models
{
    public class Genre
    {
        public int id { get; set; }
        public string genre { get; set; }
        public int? parentGenre { get; set; }
        public List<int> subGenres { get; set; }
        public List<int> books { get; set; }

        public override string? ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
