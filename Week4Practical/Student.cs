using System;
using System.Collections.Generic;
using System.Text;

namespace Week4Practical
{
    class Student
    {
        private int id;
        private string name;
        private int age;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set {  name = value; }
        }
        public int Age
        {
            get { return age; }
            set {  age = value; }
        }

        public Student(int studentId, string studentName, int studentAge)
        {
            this.Id = studentId;
            this.Name = studentName;
            this.Age = studentAge;
        }

        public void Display()
        {
            Console.WriteLine($"Student Id: {Id}");
            Console.WriteLine($"Student name: {Name}");
            Console.WriteLine($"Student age: {Age}");
        }
    }
}
