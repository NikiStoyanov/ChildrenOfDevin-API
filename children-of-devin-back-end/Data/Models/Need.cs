﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace children_of_devin_back_end.Data.Models
{
    public class Need
    {
        public Need(string content, string personId)
        {
            this.Id = Guid.NewGuid().ToString();
            
            this.Content = content;
            this.PersonId = personId;

            this.Suggestions = new HashSet<Suggestion>();
        }

        public string Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Content { get; set; }

        [Required]
        public string PersonId { get; set; }

        public Person Person { get; set; }

        public ICollection<Suggestion> Suggestions { get; set; }
    }
}
