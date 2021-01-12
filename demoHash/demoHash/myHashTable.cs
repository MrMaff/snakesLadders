using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoHash
{
    class myHashTable
    {
        student[] table;

        public myHashTable(int numStudents)
        {
            table = new student[(numStudents + 10)];
        }

        private int myHash(string key)
        {
            int index = 0;

            //Hashing algorith

            return index;
        }

        public void Add(student newRecord)
        {
            //extract the key
            //hash the key
            //put the new record into the array at the calcualted index
            //check for collision - rehash if necessary
        }

        public void Remove(student removeData)
        {
            //extract the key
            //hash the key
            //check for collision - and rehash if necessary
            //remove the data from the location

        }

        public void Remove(string studentcode)
        {
            //hash the key
            //check for collision - and rehash if necessary
            //remove the data from the location

        }

        public student GetStudent(string studentcode)
        {
            student tempStudent = new student();

            //hash the key
            //check for collision - and rehash if necessary

            return tempStudent;
        }

        public bool Find(string studentCode)
        {

            return true;
        }


    }
}
