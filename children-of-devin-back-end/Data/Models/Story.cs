using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using children_of_devin_back_end.Data.Models.Enums;

namespace children_of_devin_back_end.Data.Models
{
    public class Story : BaseEntity
    {
        public Story()
        {
        }

        public Story(string authorId, string town, string content, byte[] image)
        {
            this.AuthorId = authorId;
            this.Town = town;
            this.Content = content;
            this.Image = image;
        }

        public string AuthorId { get; set; }

        public virtual Person Author { get; set; }

        [MaxLength(100)]
        public string Town { get; set; }

        public StoryStatus Status { get; set; }

        public string Content { get; set; }

        public byte[] Image { get; set; }
    }
}
