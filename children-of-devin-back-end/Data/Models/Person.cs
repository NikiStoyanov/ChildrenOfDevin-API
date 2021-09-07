using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace children_of_devin_back_end.Data.Models
{
    public class Person : BaseEntity
    {
        public Person()
        {
            
        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;

            this.Needs = new HashSet<Need>();
            this.Stories = new HashSet<Story>();
        }

        [MaxLength(100)]
        public string Name { get; set; }

        public int Age { get; set; }

        public virtual ICollection<Need> Needs { get; set; }

        public virtual ICollection<Story> Stories { get; set; }
    }
}