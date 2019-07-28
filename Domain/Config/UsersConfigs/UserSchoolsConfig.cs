using Domain.Model.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Config.UsersConfigs
{
  public  class UserSchoolsConfig : IEntityTypeConfiguration<UserSchool>
    {

        public void Configure(EntityTypeBuilder<UserSchool> builder)
        {

            builder.ToTable("Sys_UserSchool");
            builder.HasKey(k => k.Id);
            builder.Property(u => u.UserId).IsRequired();
            builder.Property(u => u.SchoolId).IsRequired();
            builder.HasOne(p => p.Schools)
               .WithMany(p => p.UsersSchools)
               .HasForeignKey(key => key.SchoolId)
               .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.User)
               .WithMany(p => p.UsersSchool)
               .HasForeignKey(key => key.UserId)
               .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
