using Newtonsoft.Json;

namespace LibraryDisplay.Models
{
    public class Genre:IRoutable
    {
        public int id { get; set; }
        public string genre { get; set; }
        public int? parentGenre { get; set; }
        public HashSet<int> subGenres { get; set; }
        public HashSet<int> books { get; set; }
        [JsonIgnore] public string route { get; set; } = "genres";

        public Genre()
        {
            genre = string.Empty;
            subGenres = new HashSet<int>();
            books = new HashSet<int>();
        }
        public override bool Equals(object? obj)
        {
            return obj is Genre genre &&
                   id == genre.id &&
                   this.genre == genre.genre &&
                   parentGenre == genre.parentGenre &&
                   subGenres.SetEquals(genre.subGenres) &&
                   books.SetEquals(genre.books);
        }

        public override string? ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
