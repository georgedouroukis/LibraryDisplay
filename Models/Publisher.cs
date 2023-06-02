using Newtonsoft.Json;

namespace LibraryDisplay.Models
{
    public class Publisher
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public HashSet<int> books { get; set; }

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
