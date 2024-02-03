using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShopApplication.Models
{
    public class ClientEntity
    {
        public Guid Id { get; set; }

        public string LastName { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        private string Pasword { get; set; } = string.Empty;

        public List<ShopEntity> Shops { get; set; } = [];

    }
}
