using HW22.Domain.Core.Entities;
using HW22.framework;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Infra.Db.SqlServer.Ef.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasOne(u => u.Wallet)
                .WithOne(w => w.User)
                .HasForeignKey<Wallet>(w => w.UserId);

            builder.HasMany(u => u.Orders)
                .WithOne(o => o.User)
                .HasForeignKey(o => o.UserId);

            builder.Property(u => u.UserName).HasMaxLength(50);
            builder.Property(u => u.Address).HasMaxLength(500);
            builder.Property(u => u.FirstName).HasMaxLength(50);
            builder.Property(u => u.LastName).HasMaxLength(50);
            
            
            var hasher = new PasswordHasher<ApplicationUser>();

            builder.HasData(new List<ApplicationUser>
            {
                new ApplicationUser { Id = 1,
                    FirstName ="Sarina" ,
                    LastName ="Rafiee" ,
                    Address = "Tehran,piroozi",
                    PasswordHash = hasher.HashPassword(null, "1234567"),
                    CreatedAt = new DateTime(2025, 11, 30, 14, 35, 00),
                    PhoneNumber = "09101234563",
                    UserName="SarinaRmf",
                    NormalizedUserName = "SARINARMF",
                    Email = "Sarina@gmail.com",
                    NormalizedEmail ="SARINA@GMAIL.COM",
                    ConcurrencyStamp = new string(Guid.NewGuid().ToString()),
                    SecurityStamp =new string(Guid.NewGuid().ToString()),
                    },

                new ApplicationUser { Id = 2,
                    FirstName ="Bahar" ,
                    LastName ="Mahmoodi" ,
                    Address = "Karaj,Jahanshar",
                    PasswordHash = hasher.HashPassword(null, "1234567"),
                    CreatedAt = new DateTime(2025, 11, 30, 14, 35, 00),
                    PhoneNumber = "09101234563",UserName="Bahar24" ,
                    NormalizedUserName = "BAHAR24",
                    Email = "Bahar@gmail.com",
                    NormalizedEmail = "BAHAR@GMAIL.COM",
                    ConcurrencyStamp = new string(Guid.NewGuid().ToString()),
                    SecurityStamp =new string(Guid.NewGuid().ToString()),
                    },

                new ApplicationUser { Id = 3,
                    FirstName ="Mahsa" ,
                    LastName ="Ghafari" ,
                    Address = "Karaj,Banafshe",
                    PasswordHash = hasher.HashPassword(null, "1234567"),
                    CreatedAt = new DateTime(2025, 11, 30, 14, 35, 00),
                    PhoneNumber = "09101234563",
                    UserName="Mahsa24",
                    NormalizedUserName = "MAHSA24",
                    Email = "Mahsa@gmail.com",
                    NormalizedEmail = "MAHSA@GMAIL.COM",
                    ConcurrencyStamp = new string(Guid.NewGuid().ToString()),
                    SecurityStamp =new string(Guid.NewGuid().ToString()),
                    },

                new ApplicationUser { Id = 4,
                    FirstName ="Azar" ,
                    LastName ="Farahani" ,
                    Address = "Tehran,piroozi",
                    PasswordHash = hasher.HashPassword(null, "1234567"),
                    CreatedAt = new DateTime(2025, 11, 30, 14, 35, 00),
                    PhoneNumber = "09101234563",
                    UserName="AzarRmf",
                    NormalizedUserName = "AZARRMF",
                    Email = "Azar@gmail.com",
                    NormalizedEmail = "AZAR@GMAIL.COM",
                    ConcurrencyStamp = new string(Guid.NewGuid().ToString()),
                    SecurityStamp =new string(Guid.NewGuid().ToString()),
                    }
            });
        }
    }
}
