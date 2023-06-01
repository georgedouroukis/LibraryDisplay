namespace LibraryDisplay.Models
{
    public class Author
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string description { get; set; }
        public List<int> books { get; set; }

    }
}
