using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace children_of_devin_back_end.Data.Models
{
    public class Story
    {
        public Story(string authorId, int age, string town, string content, byte[] image)
        {
            this.Id = Guid.NewGuid().ToString();

            this.AuthorId = authorId;
            this.Age = age;
            this.Town = town;
            this.Content = content;
            this.Image = image;
        }

        public string Id { get; set; }

        public string AuthorId { get; set; }

        public Person Author { get; set; }

        [Range(1, 200)]
        public int Age { get; set; }

        [MaxLength(100)]
        public string Town { get; set; }

        public string Content { get; set; }

        public byte[] Image { get; set; }
    }
}
