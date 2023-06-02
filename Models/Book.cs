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
        public List<int> genres { get; set; }
        public List<int> authors { get; set; }

        public override string? ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }


}
