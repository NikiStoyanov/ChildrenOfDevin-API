using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using children_of_devin_back_end.Data.Models;
using children_of_devin_back_end.Services;
using Microsoft.AspNetCore.Mvc;

namespace children_of_devin_back_end.Controllers
{
    public class BaseController<TEntity, TService> : ControllerBase
        where TEntity : BaseEntity
        where TService : BaseService<TEntity>
    {
        protected readonly TService _service;

        public BaseController(TService service)
        {
            _service = service;
        }

        [HttpGet]
        public virtual async Task<ActionResult<string>> All()
            => await this._service.GetAllAsync();

        [HttpPost]
        public async Task Add(TEntity entity)
            => await this._service.AddAsync(entity);

        [HttpDelete]
        public async Task Delete()
            => await this._service.DeleteAsync("1");
    }
}
