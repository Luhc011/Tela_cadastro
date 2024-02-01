using System.Linq.Expressions;

namespace Tela_Cadastro.Model.Interfaces.Repositories
{
    public interface IRepository<T> : IDisposable where T : class
    {
        Task AdicionarAsync(T entity);
        Task UpdateAsync(T entity);
        Task RemoverAsync(int id);
        Task<IEnumerable<T>> BuscarTodosAsync();
        Task<IEnumerable<T>> BuscarAsync(Expression<Func<T, bool>> predicate);
    }
}
