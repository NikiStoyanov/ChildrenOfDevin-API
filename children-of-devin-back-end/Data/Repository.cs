using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace children_of_devin_back_end.Data
{
    public class Repository<T> : IRepository<T>
        where T : class
    {
        private readonly ApplicationDbContext _appDbContext;
        private readonly DbSet<T> _dbSet;

        /// <summary>
        /// Initializes a new instance of the <see cref="Repository{T}"/> class.
        /// </summary>
        /// <param name="appDbContext"></param>
        public Repository(ApplicationDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
            this._dbSet = appDbContext.Set<T>();
        }

        public async Task AddAsync(T model)
        {
            await this._appDbContext.AddAsync<T>(model);
        }

        public void Delete(T model)
        {
            this._appDbContext.Remove<T>(model);
        }

        public async Task<T> GetAsync(string id)
        {
            return await this._dbSet.FindAsync(id);
        }

        public void Update(T model)
        {
            this._appDbContext.Update<T>(model);
        }

        public async Task SaveChangesAsync()
        {
            await this._appDbContext.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            var records = await this._dbSet.ToListAsync();

            return records;
        }
    }
}
