using HW22.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace HW22.Infra.Db.SqlServer.Ef.Configurations
{
    public class ProductConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(p => p.Category)
                .WithMany(p => p.Products)
                .HasForeignKey(p => p.CategoryId);

            builder.Property(p => p.Name).HasMaxLength(100);
            builder.Property(p => p.Name).HasMaxLength(200);

            builder.Property(p => p.Price)
                .HasPrecision(18, 3);


            builder.HasData(new List<Product> {
                new Product {Id = 1 , Name = "Classic Trench Coat" , CategoryId = 1 , Count = 3 , CreatedAt = new DateTime(2025, 11, 30, 14, 35, 00) , Price = 500000,ImagePath = "/Images/Products/product-04.jpg",Description = "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat."},
                new Product {Id = 2 , Name = "Only Check Trouser" , CategoryId = 2 , Count = 5 , CreatedAt = new DateTime(2025, 11, 30, 14, 35, 00) , Price = 600000,ImagePath = "/Images/Products/product-03.jpg",Description = "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat."},
                new Product {Id = 3 , Name = "Vintage Inspired Classic" , CategoryId = 3 , Count = 6 , CreatedAt = new DateTime(2025, 11, 30, 14, 35, 00) , Price =700000,ImagePath = "/Images/Products/product-06.jpg",Description = "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat."},
                new Product {Id = 4 , Name = "Pieces Metallic Printed" , CategoryId = 4, Count = 4 , CreatedAt = new DateTime(2025, 11, 30, 14, 35, 00) , Price = 200000, ImagePath = "/Images/Products/1.jpg",Description = "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat."},
            });
        }
    }
}
