using System;

namespace InheritanceAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student =
            new Student(4, "Anusha", "Andhra", 6304899731, "EC-1", 92, "A+", 70000);
            Console.WriteLine("Student Details :");
            Console.WriteLine("-----------");
            student.Details();
            Console.WriteLine("=========");
            Console.WriteLine();


            TeachingStaff teachingstaff =
            new TeachingStaff(202, "Vidya", "Rajampet", 8186868610, "Faculty", 30000, "PHD", "AITS");
            Console.WriteLine("Teaching Staff Details :");
            Console.WriteLine("-------");
            teachingstaff.Details();
            Console.WriteLine("=========");
            Console.WriteLine();

            NonTeachingStaff nonteachingstaff =
            new NonTeachingStaff(301, "Richard", "Banglore", 9110785585, "HOD", 90000, "ECE", 1006);
            Console.WriteLine("Non Teaching Staff Details :");
            Console.WriteLine("---------");
            nonteachingstaff.Details();
            Console.WriteLine();
        }
    }
}