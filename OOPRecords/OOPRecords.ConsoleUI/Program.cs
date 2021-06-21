using System;
using MetalUp;
using OOPRecords.Model;

namespace OOPRecords.ConsoleUI
{
    class Program
    {
        static void Main()
        {
            var context = new DatabaseContext("MLOOOPRecords");
            var students = new StudentRepository(context);
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Main Menu");
                Console.WriteLine("1. Create Student");
                Console.WriteLine("2. Find Student");
                Console.WriteLine("3. All Students");
                int selection = ConsolePlus.ReadInteger("Select option: ", 1, 3);
                Console.Clear();
                switch (selection)
                {
                    case 1: CreateStudent(students); break;
                    case 2: FindStudent(students); break;
                    case 3: AllStudents(students); break;
                }
                Console.WriteLine("Press any key to continue ...");
                Console.ReadKey();
            }
        }
        private static void AllStudents(StudentRepository students)
        {
            ConsolePlus.WriteList(students.AllStudents(), "\n");
        }
        private static void FindStudent(StudentRepository students)
        {
            Console.WriteLine("Find Student");
            string match = ConsolePlus.ReadString("Last name or part of last name: ", 1);
            ConsolePlus.WriteList(students.FindStudentByLastName(match), "\n");
        }
        private static void CreateStudent(StudentRepository students)
        {
            Console.WriteLine("Create Student");
            string firstName = ConsolePlus.ReadString("First Name: ", 1);
            string lastName = ConsolePlus.ReadString("Last Name: ", 1);
            DateTime dob = ConsolePlus.ReadDate("Date Of Birth: ", -10000, -1000);
            students.NewStudent(firstName, lastName, dob);
        }
    }
}
