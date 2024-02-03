using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportShopApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShopApplication.Configuration
{
      class ShopConfiguration : IEntityTypeConfiguration<ShopEntity>
    {
        public void Configure(EntityTypeBuilder<ShopEntity> builder)
        {

            //builder.HasKey(s => s.Id);

            //builder
            //    .HasOne()
            //    .WithMany();
        
        
        }


    }
}
