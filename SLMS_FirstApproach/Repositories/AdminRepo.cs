using System.Collections.Generic;
using System.Linq;
using SLMS_FirstApproach.Models;

namespace SLMS_CodeFirst.Repositories
{
    public class AdminRepo : IAdminRepo
    {
        readonly SLMSContext context;
        public AdminRepo(SLMSContext Context)
        {
            context = Context;
        }
        public void AddNewAdmin(Admin a)
        {
            context.Admins.Add(a);
            context.SaveChanges();
        }

        public void AddNewStudent(Student s)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteAdmin(int id)
        {
            Admin a = context.Admins.FirstOrDefault(a => a.AdminId == id);
            if (a != null)
            {
                context.Admins.Remove(a);
                context.SaveChanges();
            }
        }

        public void DeleteStudent(int id)
        {
            throw new System.NotImplementedException();
        }

        public Admin GetAdminById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Admin> GetAllAdmins()
        {
            return context.Admins.ToList();
        }

        public List<Student> GetAllStudents()
        {
            throw new System.NotImplementedException();
        }

        public Student GetStudentById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateAdmin(Admin newAdmin)
        {
            Admin a = context.Admins.FirstOrDefault(a => a.AdminId == newAdmin.AdminId);
            if (a != null)
            {
                a.Id = newAdmin.Id;
                a.Username = newAdmin.Username;
                a.Passwd = newAdmin.Passwd;
                context.SaveChanges();

            }
        }

        public void UpdateEvent(Student e)
        {
            throw new System.NotImplementedException();
        }

        List<Admin> IAdminRepo.GetAllStudents()
        {
            throw new System.NotImplementedException();
        }
    }
}
