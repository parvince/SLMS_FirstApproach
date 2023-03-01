using SLMS_FirstApproach.Models;
using System.Collections.Generic;

namespace SLMS_CodeFirst.Repositories
{
    public interface IAdminLeaveRepo
    {
        List<AdminLeave> GetAllAdminLeaves();
        void AddNewAdminLeave(AdminLeave a);
        void UpdateAdminLeave(AdminLeave a);
        void DeleteAdminLeave(int id);
        AdminLeave GetAdminLeaveById(int id);
    }
}