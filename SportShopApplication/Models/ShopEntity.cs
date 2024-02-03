namespace SportShopApplication.Models
{
    public class ShopEntity
    {
        public Guid Id { get; set; }

        public string Address { get; set; } = string.Empty;

        public string Director { get; set; } = string.Empty;

        public List<ProductEntity> Products { get; set; } = [];

        public List<EmployeeEntity> Employees { get; set; } = [];

        public List<ClientEntity> Clients { get; set; } = [];


    }
}

