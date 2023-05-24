using System;
using System.ComponentModel.DataAnnotations;

namespace Net.Data.Entities
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Id} : {Name} {LastName} : {Age}";
        }
    }
}