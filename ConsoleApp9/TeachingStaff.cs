using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAssignment
{
    internal class TeachingStaff : Person
    {
        //public int StaffId { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }
        public string Qualification { get; set; }
        public string Subject { get; set; }

        public TeachingStaff(int id, string name, string address, double phone, string designation, double salary, string qualification, string subject) : base(id, name, address, phone)
        {
            //this.Id = staffid;
            this.Designation = designation;
            this.Salary = salary;
            this.Qualification = qualification;
            this.Subject = subject;
        }
        public override void Details()
        {
            base.Details();
            //Console.WriteLine("staffid " + StaffId);
            Console.WriteLine("Designation :" + Designation);
            Console.WriteLine("Salary :" + Salary);
            Console.WriteLine("Qualification :" + Qualification);
            Console.WriteLine("Subject :" + Subject);

        }
    }
}
