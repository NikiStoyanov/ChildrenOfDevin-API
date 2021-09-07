using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace children_of_devin_back_end.Data.Models
{
    public class Suggestion : BaseEntity
    {
        public Suggestion()
        {
            
        }

        public Suggestion(string volunteerName, string email, string phone, string content, string needId)
        {
            this.VolunteerName = volunteerName;
            this.Email = email;
            this.Phone = phone;
            this.Content = content;
            this.NeedId = needId;
        }

        [Required]
        [MaxLength(100)]
        public string VolunteerName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }

        [Required]
        [MaxLength(500)]
        public string Content { get; set; }

        [Required]
        public string NeedId { get; set; }

        public virtual Need Need { get; set; }
    }
}
