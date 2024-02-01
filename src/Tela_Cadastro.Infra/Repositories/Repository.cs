using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Tela_Cadastro.Infra.Data;
using Tela_Cadastro.Model.Interfaces.Repositories;

namespace Tela_Cadastro.Infra.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly AppDbContext Db;
        protected readonly DbSet<T> DbSet;

        protected Repository(AppDbContext db)
        {
            Db = db;
            DbSet = db.Set<T>();
        }

        public async Task AdicionarAsync(T entity)
        {
            DbSet.Add(entity);
            await Db.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> BuscarAsync(Expression<Func<T, bool>> predicate)
            => await DbSet.Where(predicate).ToListAsync();

        public async Task<IEnumerable<T>> BuscarTodosAsync() => await DbSet.ToListAsync();

        public async Task UpdateAsync(T entity)
        {
            DbSet.Update(entity);
            await Db.SaveChangesAsync();
        }

        public async Task RemoverAsync(int id)
        {
            var login = await Db.Logins.FindAsync(id) ?? throw new Exception("err");
            Db.Logins.Remove(login);
            await Db.SaveChangesAsync();
        }

        public void Dispose() => Db?.Dispose();

    }
}

