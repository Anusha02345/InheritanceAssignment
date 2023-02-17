using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAssignment
{
    internal class NonTeachingStaff : Person
    {
        public string Designation { get; set; }
        public double Salary { get; set; }

        public string DeptName { get; set; }
        public int ManagerId { get; set; }

        public NonTeachingStaff(int id, string name, string address, double phone, string designation, double salary, string deptname, int managerid) : base(id, name, address, phone)
        {
            this.Designation = designation;
            this.Salary = salary;
            this.DeptName = deptname;
            this.ManagerId = managerid;
        }
        public override void Details()
        {
            base.Details();
            Console.WriteLine("Designation :" + Designation);
            Console.WriteLine("Salary :" + Salary);
            Console.WriteLine("Department Name :" + DeptName);
            Console.WriteLine("Manager Id :" + ManagerId);
        }
    }
}
