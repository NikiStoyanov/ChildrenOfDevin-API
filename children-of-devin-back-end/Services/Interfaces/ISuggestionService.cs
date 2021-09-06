using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace children_of_devin_back_end.Services.Interfaces
{
    public interface ISuggestionService
    {
        public Task AddAsync();

        public void Delete(string id);
    }
}
