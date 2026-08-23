namespace TtcLesson2MVC.Models
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public DateTime createdAt { get; set; }
        public string image { get; set; }
    }
}
