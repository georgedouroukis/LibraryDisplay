using Newtonsoft.Json;

namespace LibraryDisplay.Models
{
    public class Author:IRoutable
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string description { get; set; }
        public HashSet<int> books { get; set; }
        [JsonIgnore] public string route { get; set; } = "authors";

        public Author()
        {
            firstName = string.Empty;
            lastName = string.Empty;
            middleName = string.Empty;
            description = string.Empty;
            books = new HashSet<int>();
        }

        public Author(Author other)
        {
            firstName = other.firstName;
            lastName = other.lastName;
            middleName = other.middleName;
            description = other.description;
            books = other.books;
        }
        public override bool Equals(object? obj)
        {
            return obj is Author author &&
                   id == author.id &&
                   firstName == author.firstName &&
                   lastName == author.lastName &&
                   middleName == author.middleName &&
                   description == author.description &&
                   books.SetEquals(author.books);
        }

        public override string? ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
