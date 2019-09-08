using Domain.Model.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Config.UsersConfigs
{
    public class SysFormsConfig : IEntityTypeConfiguration<SysForms>
    {

        public void Configure(EntityTypeBuilder<SysForms> builder)
        {

            builder.ToTable("Sys_Forms");
            builder.HasKey(k => k.Id);

        }

       
    }
}
