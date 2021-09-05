using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace children_of_devin_back_end.Data.Models
{
    public class Person
    {
        public Person(string name, int age)
        {
            this.Id = Guid.NewGuid().ToString();

            this.Name = name;
            this.Age = age;

            this.Needs = new HashSet<Need>();
            this.Stories = new HashSet<Story>();
        }

        public string Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        public int Age { get; set; }

        public ICollection<Need> Needs { get; set; }

        public ICollection<Story> Stories { get; set; }
    }
}