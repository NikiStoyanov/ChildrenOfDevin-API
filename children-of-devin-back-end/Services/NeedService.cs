using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using children_of_devin_back_end.Data;
using children_of_devin_back_end.Data.Models;
using children_of_devin_back_end.Services.Interfaces;
using Newtonsoft.Json;

namespace children_of_devin_back_end.Services
{
    public class NeedService : INeedService
    {
        private readonly IRepository<Need> _needRepo;

        public NeedService(IRepository<Need> needRepo)
        {
            this._needRepo = needRepo;
        }

        public async Task AddAsync(Need need)
        {
            await this._needRepo.AddAsync(need);

            await this._needRepo.SaveChangesAsync();
        }

        public async Task<string> GetAllAsync()
        {
            var needs = await this._needRepo.GetAllAsync();

            var json = JsonConvert.SerializeObject(needs);

            return json;
        }

        public async Task DeleteAsync(string id)
        {
            var need = await this._needRepo.GetAsync(id);

            this._needRepo.Delete(need);

            await this._needRepo.SaveChangesAsync();
        }
    }
}
