using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using children_of_devin_back_end.Data.Models;
using Microsoft.AspNetCore.Http;

namespace children_of_devin_back_end.Services.Interfaces
{
    public interface INeedService
    {
        public Task AddAsync(Need need);

        public Task<string> GetAllAsync();

        public Task DeleteAsync(string id);
    }
}
