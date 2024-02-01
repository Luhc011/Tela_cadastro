using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tela_Cadastro.Model.Models;

namespace Tela_Cadastro.Infra.Mappings
{
    public class LoginMap : IEntityTypeConfiguration<Login>
    {
        public void Configure(EntityTypeBuilder<Login> builder)
        {
            builder.HasKey(l => l.Id);

            builder.Property(l => l.Email).IsRequired().HasMaxLength(100).HasColumnName("EMAIL").HasAnnotation("Relational:ColumnType", "varchar(100)");

            builder.Property(l => l.Celular).IsRequired().HasMaxLength(15).HasAnnotation("Relational:ColumnType", "varchar(15)");

            builder.Property(l => l.Senha).IsRequired().HasMaxLength(100);

            builder.Property(l => l.TrocarSenha).IsRequired().HasDefaultValue(false);
        }
    }
}

