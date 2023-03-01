using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using SLMS_FirstApproach.Models;

namespace SLMS_CodeFirst.Repositories
{
    public interface IStudentRepo1
    {
        List<Student> GetAllStudents();
        void AddNewStudent(Student s);
        void UpdateEvent(Student s);
        void DeleteStudent(int id);
        Student GetStudentById(int id);
    }
}