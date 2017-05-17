using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjectPattern
{
    public class StudentDAOPImpl : IStudentDAOP
    {
        List<Student> students;

        public StudentDAOPImpl()
        {
            students = new List<Student>();
            Student student1 = new Student("Lakshmi Bhargava", 1);
            Student student2 = new Student("Chaitanya", 2);
            Student student3 = new Student("Gouthama", 3);
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
        }


        public void AddStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine("Student {0} with Roll No {1}: been added to database",student.Name,student.RollNumber);
        }

        public void DeleteStudent(Student student)
        {
            students.Remove(student);
            Console.WriteLine("Student with Roll No : " + student.GetRollNumber() + ", deleted from database");
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public Student GetStudent(int rollNumber)
        {
            return students.Where(m => m.RollNumber == rollNumber).FirstOrDefault();
        }
        public void UpdateStudent(Student student)
        {
            students.Where(m => m.RollNumber == student.RollNumber).FirstOrDefault().SetName(student.GetName());
            Console.WriteLine("Student {0} updated in database", student.Name);

        }
    }
}
