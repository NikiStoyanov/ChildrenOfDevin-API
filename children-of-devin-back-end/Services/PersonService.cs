using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using children_of_devin_back_end.Data;
using children_of_devin_back_end.Data.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace children_of_devin_back_end.Services
{
    public class PersonService : BaseService<Person>
    {
        public PersonService(ApplicationDbContext db) 
            : base(db)
        {
        }
    }
}
