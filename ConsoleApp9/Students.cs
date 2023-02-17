using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAssignment
{
    internal class Student : Person
    {
        public string Class { get; set; }
        public int Marks { get; set; }
        public string Grade { get; set; }
        public double Fees { get; set; }

        public Student(int id, string name, string address, double phone, string _class, int marks, string grade, double fees) : base(id, name, address, phone)
        {
            this.Class = _class;
            this.Marks = marks;
            this.Grade = grade;
            this.Fees = fees;
        }
        public override void Details()
        {
            base.Details();
            Console.WriteLine("Class :" + Class);
            Console.WriteLine("Marks :" + Marks);
            Console.WriteLine("Grade :" + Grade);
            Console.WriteLine("Fees :" + Fees);
        }
    }
}