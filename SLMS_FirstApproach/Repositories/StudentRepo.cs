using System.Collections.Generic;
using System.Linq;
using SLMS_FirstApproach.Models;

namespace SLMS_CodeFirst.Repositories
{
    public class StudentRepo : IStudentRepo
    {
        readonly SLMSContext context;
        public StudentRepo(SLMSContext Context)
        {
            context = Context;
        }
        public void AddNewStudent(Student s)
        {
            context.Students.Add(s);
            context.SaveChanges();
        }

        public void DeleteStudent(int id)
        {
            Student s = context.Students.FirstOrDefault(s => s.StudentId == id);
            if (s != null)
            {
                context.Students.Remove(s);
                context.SaveChanges();
            }
        }

        public List<Student> GetAllStudents()
        {
            return context.Students.ToList();
        }


        public void UpdateStudent(Student newStudent)
        {
            Student s = context.Students.FirstOrDefault(s => s.StudentId == newStudent.StudentId);
            if (s != null)
            {
                s.Id = newStudent.Id;
                s.Fullname = newStudent.Fullname;
                s.Email = newStudent.Email;
                s.Parentphone = newStudent.Parentphone;

                context.SaveChanges();

            }
        }

        public Student GetStudentById(int id)
        {
            Student s = context.Students.Find(id);
            return s;
        }
    }
}