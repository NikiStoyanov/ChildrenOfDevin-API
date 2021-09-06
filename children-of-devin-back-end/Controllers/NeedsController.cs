using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using children_of_devin_back_end.Data.Models;
using children_of_devin_back_end.Services.Interfaces;
using Newtonsoft.Json;

namespace children_of_devin_back_end.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class NeedsController : ControllerBase
    {
        private readonly INeedService _needService;

        public NeedsController(INeedService needService)
        {
            _needService = needService;
        }

        public async Task<ActionResult<string>> All() 
            => await this._needService.GetAllAsync();

        public async Task Add(Need need) 
            => await this._needService.AddAsync(need);

        public async Task Delete(string id) 
            => await this._needService.DeleteAsync(id);
    }
}
