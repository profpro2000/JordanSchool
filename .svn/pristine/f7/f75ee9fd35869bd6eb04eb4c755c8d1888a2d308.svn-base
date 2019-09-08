using Domain.Model.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Config.UsersConfigs
{
  public  class SysRolesConfig : IEntityTypeConfiguration<SysRoles>
    {

        public void Configure(EntityTypeBuilder<SysRoles> builder)
        {

            builder.ToTable("Sys_Roles");
            builder.HasKey(k => k.Id);
            builder.Property(u => u.name).IsRequired();

        }

        
    }
}
