using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Infra.Db.SqlServer.Ef.Configurations
{
    public class IdentityRoleConfiguration : IEntityTypeConfiguration<IdentityRole<int>>
    {
        public void Configure(EntityTypeBuilder<IdentityRole<int>> builder)
        {
            var roles = new List<IdentityRole<int>>
            {
                new IdentityRole<int>()
            {
                Id = 1,
                ConcurrencyStamp = new string(Guid.NewGuid().ToString()),
                NormalizedName = "ADMIN",
                Name = "Admin",
            },

                new IdentityRole<int>()
            {
                Id = 2,
                ConcurrencyStamp = new string(Guid.NewGuid().ToString()),
                NormalizedName = "USER",
                Name = "User",
            }
            };
            builder.HasData(roles);
        }
    }
}
