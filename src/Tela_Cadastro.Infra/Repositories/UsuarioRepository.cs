using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Tela_Cadastro.Infra.Data;
using Tela_Cadastro.Model.Interfaces.Repositories;
using Tela_Cadastro.Model.Models;

namespace Tela_Cadastro.Infra.Repositories
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        protected UsuarioRepository(AppDbContext db) : base(db) { }


        public async Task CriarUsuario(Usuario usuario) 
            => await AdicionarAsync(usuario);

        public async Task<IEnumerable<Usuario>> BuscarUsuario(Expression<Func<Usuario, bool>> expression) 
            => await Db.Usuarios.AsNoTracking().Where(expression).ToListAsync();

        public async Task AtualizarUsuario(Usuario usuario) 
            => await UpdateAsync(usuario);

        public async Task RemoverUsuario(int id) 
            => await RemoverAsync(id);
    }
}
