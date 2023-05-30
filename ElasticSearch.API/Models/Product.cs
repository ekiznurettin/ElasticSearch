namespace ElasticSearch.API.Models
{
    public class Product
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public ProductFeature? ProductFeature { get; set; }
    }
}
