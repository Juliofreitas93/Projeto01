﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto1.Back;

namespace Projeto1.ConnectionDB
{
    public class EstoqueMap : EntityTypeConfiguration<Estoque>
    {
        public EstoqueMap()
        {
            ToTable("dbo.Estoque");
            HasKey(x => x.Id);
            Property(x => x.Description).IsRequired().HasColumnType("varchar").HasMaxLength(100);
            Property(x => x.Unit).IsRequired().HasColumnType("int");
            Property(x => x.IdDepartment).IsRequired().HasColumnType("int");

        }
    }
}
