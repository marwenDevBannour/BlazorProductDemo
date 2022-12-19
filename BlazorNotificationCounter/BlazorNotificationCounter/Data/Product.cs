namespace BlazorNotificationCounter.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Discription { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public int Qte { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; } = string.Empty;
    }
}
