using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using children_of_devin_back_end.Data.Models;
using children_of_devin_back_end.Services;
using Newtonsoft.Json;

namespace children_of_devin_back_end.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class NeedsController : BaseController<Need, NeedService>
    {
        public NeedsController(NeedService service) 
            : base(service)
        {
        }
    }
}
