using SLMS_FirstApproach.Models;
using System.Collections.Generic;

namespace SLMS_CodeFirst.Repositories
{
    public interface IAdminRepo
    {
        List<Admin> GetAllStudents();
        void AddNewAdmin(Admin a);
        void UpdateAdmin(Admin a);
        void DeleteAdmin(int id);
        Admin GetAdminById(int id);
    }
}
