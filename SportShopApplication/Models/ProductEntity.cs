namespace SportShopApplication.Models
{
     public class ProductEntity
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; } = 0;

        public Guid ShopId { get; set; }

        public ShopEntity? Shop { get; set; }

    }
}
