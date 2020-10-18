using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kanban.API.Domain.Models;
using Kanban.API.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Kanban.API.Persistence.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly AppDbContext _context;
        private DbSet<T> entities;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
            entities = context.Set<T>();
        }

        public async Task DeleteAsync(int id)
        {
            T entity = await entities.SingleOrDefaultAsync(s => s.Id == id);
            entities.Remove(entity);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await entities.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await entities.SingleOrDefaultAsync(s => s.Id == id);
        }

        public async Task InsertAsync(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            await entities.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _context.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}