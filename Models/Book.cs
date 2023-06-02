using Newtonsoft.Json;

namespace LibraryDisplay.Models
{
    public class Book
    {
        public int id { get; set; }
        public string isbn { get; set; }
        public string title { get; set; }
        public int pageNumber { get; set; }
        public string publicationDate { get; set; }
        public string description { get; set; }
        public string imageUrl { get; set; }
        public int publisher { get; set; }
        public HashSet<int> genres { get; set; }
        public HashSet<int> authors { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Book book &&
                   id == book.id &&
                   isbn == book.isbn &&
                   title == book.title &&
                   pageNumber == book.pageNumber &&
                   publicationDate == book.publicationDate &&
                   description == book.description &&
                   imageUrl == book.imageUrl &&
                   publisher == book.publisher &&
                   genres.SetEquals(book.genres) &&
                   authors.SetEquals(book.authors);
        }

        public override string? ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }


}
