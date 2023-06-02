using Newtonsoft.Json;

namespace LibraryDisplay.Models
{
    public class Author
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string description { get; set; }
        public HashSet<int> books { get; set; }

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
