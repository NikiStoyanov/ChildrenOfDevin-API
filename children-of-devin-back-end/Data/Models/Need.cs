using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace children_of_devin_back_end.Data.Models
{
    public class Need : BaseEntity
    {
        public Need()
        {
                
        }
        public Need(string content, string personId)
        {
            
            this.Content = content;
            this.PersonId = personId;

            this.Suggestions = new HashSet<Suggestion>();
        }

        [Required]
        [MaxLength(200)]
        public string Content { get; set; }

        [Required]
        public string PersonId { get; set; }

        public virtual Person Person { get; set; }

        public virtual ICollection<Suggestion> Suggestions { get; set; }
    }
}
