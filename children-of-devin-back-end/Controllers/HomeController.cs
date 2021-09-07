using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using children_of_devin_back_end.Data.Models;
using Microsoft.AspNetCore.Cors;
using Newtonsoft.Json;

namespace children_of_devin_back_end.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Index()
        {
            var people = new List<Person>()
            {
                new Person("Nikolay", 16),
                new Person("Viktor", 16),
            };

            var json = JsonConvert.SerializeObject(people);
            Console.WriteLine(json);
            return json;
        }
    }
}
