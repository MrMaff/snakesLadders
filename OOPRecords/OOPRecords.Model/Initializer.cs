using System;
using System.Collections.Generic;
using System.Text;

namespace OOPRecords.Model
{
    class Initializer
    {
        public void Seed(StudentRepository students)
        {
            var alg = NewStudent(students, "Alie", "Algol", "19/02/2004");
            var frt = NewStudent(students, "Forrest", "Fortran", "22/09/2003");
            var jav = NewStudent(students, "James", "Java", "24/03/2004");
            var cee = NewStudent(students, "Celia", "Cee-Sharp", "12/09/2003");
            var vee = NewStudent(students, "Veronica", "Vee-Bee", "05/09/2003");
            var sim = NewStudent(students, "Simon", "Simula", "31/07/2003");
            var typ = NewStudent(students, "Tilly", "TypeScript", "14/01/2003");
            var pyt = NewStudent(students, "Petra", "Python", "17/06/2003");
            var has = NewStudent(students, "Harry", "Haskell", "08/04/2003");
            var cob = NewStudent(students, "Corinie", "Cobol", "28/02/2003");
        }
        private Student NewStudent(StudentRepository students, string firstName,
        string lastName, string dob)
        {
            var s = new Student();
            s.FirstName = firstName;
            s.LastName = lastName;
            s.DateOfBirth = Convert.ToDateTime(dob);
            students.Add(s);
            return s;
        }
    }
}
