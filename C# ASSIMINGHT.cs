using System;

namespace StudentRecord
{
    class Student
    {
        private string name;
        private int id;
        private double gpa;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public double GPA
        {
            get { return gpa; }
            set
            {
                if (value >= 0 && value <= 4)
                {
                    gpa = value;
                }
                else
                {
                    Console.WriteLine("Invalid GPA. Must be between 0 and 4.");
                    gpa = 0;
                }
            }
        }

        public void DisplayRecord()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"GPA: {GPA}");
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name = "Ali";
            student1.ID = 101;
            student1.GPA = 3.5;

            Student student2 = new Student();
            student2.Name = "MOSA";
            student2.ID = 102;
            student2.GPA = 5.0; // Invalid GPA

            student1.DisplayRecord();
            student2.DisplayRecord();
        }
    }
}