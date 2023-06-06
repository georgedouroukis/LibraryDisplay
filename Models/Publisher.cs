using Newtonsoft.Json;

namespace LibraryDisplay.Models
{
    public class Publisher:IRoutable
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public HashSet<int> books { get; set; }
        [JsonIgnore] public string route { get; set; } = "publishers";

        public Publisher() 
        { 
            name = string.Empty;
            phone = string.Empty;
            email = string.Empty;
            books = new HashSet<int>();
        }

        public Publisher(Publisher other)
        {
            name = other.name;
            phone = other.phone;
            email = other.email;
            books = other.books;
        }
        public override bool Equals(object? obj)
        {
            return obj is Publisher publisher &&
                   id == publisher.id &&
                   name == publisher.name &&
                   phone == publisher.phone &&
                   email == publisher.email &&
                   books.SetEquals(publisher.books);
        }

        public override string? ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
