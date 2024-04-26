using MayTheFouthBackend.Domain.Entities;
using MayTheFouthBackend.Domain.Interfaces.IRepositories;
using MayTheFouthBackend.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace MayTheFouthBackend.Infra.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : Entity
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _set;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
            _set = _context.Set<T>();
        }

        public async Task CreateAsync(T entity)
        {
            await _set.AddAsync(entity);
        }

        public async Task<bool> DeleteAsync(int id)
        {
           var entity = await _set.FindAsync(id);
            if(entity is null)
                return false;

            _set.Remove(entity); 
            return true;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _set.AsNoTracking().ToListAsync(); 
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _set.FindAsync(id); 
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            await Task.CompletedTask; 
           _set.Entry(entity).State = EntityState.Modified;
            return true;
        }
    }
}
