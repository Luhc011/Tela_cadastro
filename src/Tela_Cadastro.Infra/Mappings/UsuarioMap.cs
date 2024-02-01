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
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).HasColumnName("Nome").HasMaxLength(100).IsRequired();
            builder.Property(x =>x.RG).HasColumnName("RG").HasMaxLength(20).IsRequired();
            builder.Property(x => x.CPF).HasColumnName("CPF").HasMaxLength(20).IsRequired();
        }
    }
}
