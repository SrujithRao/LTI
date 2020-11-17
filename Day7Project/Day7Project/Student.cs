using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Project
{
    class Student
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Age { get; set; }

        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        public Student()
        {

        }
        public void TakeStudentDataFromUser()
        {
            Console.WriteLine("enter student name");
            Name = Console.ReadLine();
            Console.WriteLine("enter age");
            int age;
            Int32.TryParse(Console.ReadLine(), out age);
            Age = age;
        }
        public override string ToString()
        {
            return "ID is " +Id + " Name is " +Name + " Age is " + Age;
        }
    }
}
