using Domain.Model.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Config.UsersConfigs
{
 public   class SysRoleFormsConfig : IEntityTypeConfiguration<SysRoleForms>
    {

        public void Configure(EntityTypeBuilder<SysRoleForms> builder)
        {

            builder.ToTable("Sys_Role_Forms");
            builder.HasKey(k => k.Id);
            builder.HasOne(p => p.SysRoles)
              .WithMany(p => p.SysRoleForms)
              .HasForeignKey(key => key.RoleId)
              .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.SysForms)
               .WithMany(p => p.SysRoleForms)
               .HasForeignKey(key => key.FormId)
               .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
