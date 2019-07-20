using Domain.Model.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Config.UsersConfigs
{
    public class UsersConfig : IEntityTypeConfiguration<Users>
    {

        public void Configure(EntityTypeBuilder<Users> builder)
        {

            builder.ToTable("Sys_Users");
            builder.HasKey(k => k.Id);
            builder.Property(u => u.Username).IsRequired();
            builder.HasIndex(p => p.Username).IsUnique();
            builder.Property(p => p.Password).IsRequired();
        }
    }
}
