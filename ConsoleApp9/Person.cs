using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAssignment
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Phone { get; set; }
        public string Address { get; set; }
        public Person(int id, string name, string address, double phone)
        {
            this.Id = id;
            this.Name = name;
            this.Phone = phone;
            this.Address = address;
        }
        public virtual void Details()
        {
            Console.WriteLine("Id :" + Id);
            Console.WriteLine("Name :" + Name);
            Console.WriteLine("Phone Number :" + Phone);
            Console.WriteLine("Address:" + Address);
        }
    }
}

