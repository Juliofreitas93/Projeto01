﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto1.Back;

namespace Projeto1.ConnectionDB
{
    public class UsersMap : EntityTypeConfiguration<Users>
    {
        public UsersMap()
        {
            ToTable("User");
            HasKey(x => x.IdUser);
            Property(x => x.Name).HasColumnName("Name_User").HasColumnType("varchar").HasMaxLength(100);
            Property(x => x.Email).HasColumnName("Email_User").HasColumnType("varchar").HasMaxLength(150);
            Property(x => x.Deparment).HasColumnName("Department").HasColumnType("varchar").HasMaxLength(150);
            Property(x => x.Password).HasColumnName("Password_User").HasColumnType("varchar").HasMaxLength(20);
            Property(x => x.DataCreat).HasColumnName("Data_Created").HasColumnType("datetime");
            Property(x => x.DataModified).HasColumnName("Data_Modified").HasColumnType("datetime");           
        }

    }
}