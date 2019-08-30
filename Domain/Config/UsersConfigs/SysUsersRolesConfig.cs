using Domain.Model.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Config.UsersConfigs
{
  public  class SysUsersRolesConfig : IEntityTypeConfiguration<SysUsersRoles>
    {

        public void Configure(EntityTypeBuilder<SysUsersRoles> builder)
        {

            builder.ToTable("Sys_Users_Roles");
            builder.HasKey(k => k.Id);
            builder.HasOne(p => p.SysRoles)
              .WithMany(p => p.SysUsersRoles)
              .HasForeignKey(key => key.RoleId)
              .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.SysUsers)
               .WithMany(p => p.SysUsersRoles)
               .HasForeignKey(key => key.UserId)
               .OnDelete(DeleteBehavior.Restrict);

        }
    
    }
}
