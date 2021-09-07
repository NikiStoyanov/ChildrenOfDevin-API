using children_of_devin_back_end.Data;
using children_of_devin_back_end.Data.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace children_of_devin_back_end.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class BaseService<T> 
        where T : BaseEntity
    {
        protected readonly ApplicationDbContext _db;
        protected readonly DbSet<T> _dbSet;

        protected BaseService(ApplicationDbContext db)
        {
            this._db = db;
            this._dbSet = this._db.Set<T>();
        }

        public async Task AddAsync(T element)
        {
            element.CreatedOn = DateTime.UtcNow;

            await this._dbSet.AddAsync(element);

            await this._db.SaveChangesAsync();
        }

        public async Task<T> GetAsync(string id) =>
            await this._dbSet.FirstOrDefaultAsync(e => e.Id == id);

        public async Task<string> GetByIdAsync(string id)
        {
            var elements = await this._dbSet.FirstOrDefaultAsync(e => e.Id == id);

            var json = JsonConvert.SerializeObject(elements, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });

            return json;
        }

        protected virtual IQueryable<T> GetAllInternal()
        {
            return this._dbSet;
        }

        public async Task<string> GetAllAsync()
        {
            var elements = await GetAllInternal().ToListAsync();

            var json = JsonConvert.SerializeObject(elements,
                new JsonSerializerSettings() {ReferenceLoopHandling = ReferenceLoopHandling.Ignore});

            return json;
        }

        public async Task DeleteAsync(string id)
        {
            var need = _dbSet.FirstOrDefault(n => n.Id == id);

            _dbSet.Remove(need ?? throw new InvalidOperationException("The need is null."));

            await _db.SaveChangesAsync();
        }
    }
}
