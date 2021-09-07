using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using children_of_devin_back_end.Data.Models;
using children_of_devin_back_end.Services;

namespace children_of_devin_back_end.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class StoriesController : BaseController<Story, StoryService>
    {
        public StoriesController(StoryService service) 
            : base(service)
        {
        }

        [HttpPost]
        public async Task Approve(string id) => 
            await _service.ApproveAsync(id);
    }
}
