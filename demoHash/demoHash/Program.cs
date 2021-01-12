using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoHash
{
    struct student
    {
        string studentCode;
        string surname;
        string firstname;
        string house;
    }

    class Program
    {
        static void Main(string[] args)
        {

            student temp = new student();

            myHashTable studentTable = new myHashTable(50);

            studentTable.Remove("6656");
            studentTable.Remove(temp);
        }
    }
}
