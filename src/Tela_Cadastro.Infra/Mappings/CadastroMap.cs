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
    public class CadastroMap : IEntityTypeConfiguration<Cadastro>
    {
        public void Configure(EntityTypeBuilder<Cadastro> builder)
        {
            builder.ToTable("Cadastro");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).HasMaxLength(40).IsRequired();
            builder.Property(x => x.Email).HasColumnName("Email").HasMaxLength(100);
            builder.Property(x => x.Senha).HasColumnName("Senha").HasMaxLength(100).IsRequired();
            builder.Property(c => c.DataCriacao).IsRequired().HasDefaultValueSql("getdate()");
            builder.Property(c => c.AtualizaData).IsRequired().HasDefaultValueSql("getdate()");
        }
    }
}


