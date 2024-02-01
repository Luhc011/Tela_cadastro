using System.Linq.Expressions;
using Tela_Cadastro.Model.Models;

namespace Tela_Cadastro.Model.Interfaces.Repositories
{
    public interface IUsuarioRepository : IRepository<Usuario>, IDisposable
    {
        Task CriarUsuario(Usuario usuario);
        Task AtualizarUsuario(Usuario usuario);
        Task RemoverUsuario(int id);
        Task<IEnumerable<Usuario>> BuscarUsuario(Expression<Func<Usuario, bool>> expression);
    }
}
