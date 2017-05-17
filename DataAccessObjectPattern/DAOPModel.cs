using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjectPattern
{
    public class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }



        public Student(string name,int rollNumber)
        {
            this.Name = name;
            this.RollNumber = rollNumber;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            this.Name = name;
        }

        public int GetRollNumber()
        {
            return RollNumber;
        }

        public void SetRollNumber(int rollNumber)
        {
            this.RollNumber = rollNumber;
        }

    }
}
