using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.Json;

namespace OOPRecords.Model
{
    public class StudentRepository
    {
        private List<Student> Students = new List<Student>();
        private const string filename = @"studentsFile.json";

        public StudentRepository()
        {
            if (File.Exists(filename))
            {
                Load();
            }
            else
            {
                var initializer = new Initializer();
                initializer.Seed(this);
                SaveAll();
            }
            
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
            SaveAll();
            return s;
        }

        public void Load()
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string json = reader.ReadToEnd();
                Students = JsonSerializer.Deserialize<List<Student>>(json);
            }
        }

        public void SaveAll()
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(Students, options);
                writer.Write(json);
                writer.Flush();
            }
        }
    }
}
