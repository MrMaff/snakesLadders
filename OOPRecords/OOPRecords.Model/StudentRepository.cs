using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace OOPRecords.Model
{
    public class StudentRepository
    {
        private DatabaseContext Context;
        private const string filename = @"studentsFile.json";

        public StudentRepository(DatabaseContext context)
        {
            Context = context;
            
        }
        public void Add(Student s)
        {
            Context.Students.Add(s);
            Context.SaveChanges();
        }
        public IEnumerable<Student> AllStudents()
        {
            return Context.Students;
        }

        public IEnumerable<Student> FindStudentByLastName(string lastname)
        {
            return from s in AllStudents()
                   where s.LastName.ToUpper().Contains(lastname.ToUpper())
                   select s;
        }

        public Student NewStudent(string firstName, string lastname, DateTime dob)
        {
            var s = new Student();
            s.FirstName = firstName;
            s.LastName = lastname;
            s.DateOfBirth = dob;
            Add(s);
            return s;
        }
    }
}
