using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace children_of_devin_back_end.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class SuggestionsController : ControllerBase
    {
        public ActionResult<string> All()
        {
            // TODO
            return null;
        }

        public ActionResult<string> Add()
        {
            // TODO
            return null;
        }

        public ActionResult<string> Delete()
        {
            // TODO
            return null;
        }
    }
}
