using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tela_Cadastro.Infra.Mappings;
using Tela_Cadastro.Model.Models;

namespace Tela_Cadastro.Infra.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Cadastro> Cadastros { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.ApplyConfiguration(new UsuarioMap());
            mb.ApplyConfiguration(new LoginMap());
            mb.ApplyConfiguration(new CadastroMap());
        }
    }
}
