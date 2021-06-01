using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPRecords.Model
{
    class StudentRepository
    {
        private List<Student> Students = new List<Student>();

        public StudentRepository()
        {
            var initializer = new Initializer();
            initializer.Seed(this);
        }
        public void Add(Student s)
        {
            Students.Add(s);
        }
        public IEnumerable<Student> AllStudents()
        {
            return Students;
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
