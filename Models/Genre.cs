using Newtonsoft.Json;

namespace LibraryDisplay.Models
{
    public class Genre
    {
        public int id { get; set; }
        public string genre { get; set; }
        public int? parentGenre { get; set; }
        public HashSet<int> subGenres { get; set; }
        public HashSet<int> books { get; set; }

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
