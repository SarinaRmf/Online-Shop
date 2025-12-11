using HW22.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Infra.Db.SqlServer.Ef.Configurations
{
    public class CategoryConfigurations : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);

            builder.Property(p => p.Name).HasMaxLength(50);

            builder.HasData(new List<Category>
            {
                new Category { Id = 1 , Name = "Women" , ImagePath = "/Images/Category/banner-04.jpg", Description = "New women collection"},
                new Category { Id = 2 , Name = "Men",ImagePath = "/Images/Category/banner-05.jpg",Description = "New Men collection"},
                new Category { Id = 3 , Name = "Accessory",ImagePath = "/Images/Category/banner-03.jpg",Description = "New Accessory collection"},
                new Category { Id = 4 , Name = "Kids",ImagePath = "/Images/Category/istockphoto-1076514954-612x612.jpg",Description = "New Kids collection"},

            });
        }
    }
}
