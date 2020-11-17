using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Project
{
    class Course
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Fees { get; set; }

        public Course(int id, string name, int fees)
        {
            Id = id;
            Name = name;
            Fees = fees;
        }

        public Course()
        {
        }
        public void TakeCourseDataFromUser()
        {
            Console.WriteLine("enter course name");
            Name = Console.ReadLine();
            Console.WriteLine("enter fee");
            int fee;
            Int32.TryParse(Console.ReadLine(), out fee);
            Fees = fee;
        }

        public override string ToString()
        {
            return "ID is " + Id + " Name is " + Name + " Fees is " + Fees;
        }
    }
}
