namespace LibraryDisplay.Models
{
    public class Publisher
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public List<int> books { get; set; }
    }
}
