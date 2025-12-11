using HW22.Domain.Core.Entities;
using HW22.framework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Infra.Db.SqlServer.Ef.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasOne(u => u.Wallet)
                .WithOne(w => w.User)
                .HasForeignKey<Wallet>(w => w.UserId);

            builder.HasMany(u => u.Orders)
                .WithOne(o => o.User)
                .HasForeignKey(o => o.UserId);

            builder.Property(u => u.Username).HasMaxLength(50);
            builder.Property(u => u.PasswordHash).HasMaxLength(50);
            builder.Property(u => u.Address).HasMaxLength(500);
            builder.Property(u => u.FirstName).HasMaxLength(50);
            builder.Property(u => u.LastName).HasMaxLength(50);

            builder.HasData(new List<User> 
            {
                new User { Id = 1, FirstName ="Sarina" , LastName ="Rafiee" , Address = "Tehran,piroozi",PasswordHash = "1234".ToMd5Hex(), CreatedAt = new DateTime(2025, 11, 30, 14, 35, 00),Phone = "09101234563",Username="SarinaRmf", IsAdmin = true },
                new User { Id = 2, FirstName ="Bahar" , LastName ="Mahmoodi" , Address = "Karaj,Jahanshar",PasswordHash = "1234".ToMd5Hex(), CreatedAt = new DateTime(2025, 11, 30, 14, 35, 00),Phone = "09101234563",Username="Bahar24" , IsAdmin = false},
                new User { Id = 3, FirstName ="Mahsa" , LastName ="Ghafari" , Address = "Karaj,Banafshe",PasswordHash = "1234".ToMd5Hex(), CreatedAt = new DateTime(2025, 11, 30, 14, 35, 00),Phone = "09101234563",Username="Mahsa24", IsAdmin = false },
                new User { Id = 4, FirstName ="Azar" , LastName ="Farahani" , Address = "Tehran,piroozi",PasswordHash = "1234".ToMd5Hex(), CreatedAt = new DateTime(2025, 11, 30, 14, 35, 00),Phone = "09101234563",Username="AzarRmf", IsAdmin = false }
            });
        }
    }
}
