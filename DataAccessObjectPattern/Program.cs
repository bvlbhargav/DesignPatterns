using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjectPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IStudentDAOP studentDAO = new StudentDAOPImpl();

            //print all students
            Console.WriteLine("Displaying all the students list");
            foreach(var singleStudent in studentDAO.GetAllStudents())
            {
                Console.WriteLine("Student: [RollNo : " + singleStudent.GetRollNumber() + ", Name : " + singleStudent.GetName() + " ]");
            }

            Console.WriteLine("Total Number Of Students : {0}",studentDAO.GetAllStudents().Count);

            //update student
            Student student = studentDAO.GetAllStudents().Where(m=>m.RollNumber ==1).FirstOrDefault();
            student.SetName("Michael");
            studentDAO.UpdateStudent(student);

            //get the student
            studentDAO.GetStudent(1);
            Console.WriteLine("Student: [RollNo : " + student.GetRollNumber() + ", Name : " + student.GetRollNumber() + " ]");

            Console.Read();
        }
    }
}
