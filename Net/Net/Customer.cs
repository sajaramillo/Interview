using System;
namespace Net
{
    public class Customer
    {
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