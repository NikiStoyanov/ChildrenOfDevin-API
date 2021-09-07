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
    public class SuggestionsController : BaseController<Suggestion, SuggestionService>
    {
        public SuggestionsController(SuggestionService service) 
            : base(service)
        {
        }
    }
}
