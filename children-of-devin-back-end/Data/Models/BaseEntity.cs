using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace children_of_devin_back_end.Data.Models
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        [Key]
        public string Id { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
