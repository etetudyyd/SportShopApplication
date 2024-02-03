using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShopApplication.Models
{
      public class EmployeeEntity
    {
        public Guid Id { get; set; }

        public string LastName { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        private decimal Salary { get; set; } = 0;  
        
        public Guid ShopId { get; set; }

        public ShopEntity? Shop { get; set; }

    }
}
