using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjectPattern
{
    
    public interface IStudentDAOP
    {
        List<Student> GetAllStudents();

        void UpdateStudent(Student student);

        void DeleteStudent(Student student);

        void AddStudent(Student student);

        Student GetStudent(int rollNumber);
    }
}
