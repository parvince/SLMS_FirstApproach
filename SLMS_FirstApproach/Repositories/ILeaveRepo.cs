using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using SLMS_FirstApproach.Models;

namespace SLMS_CodeFirst.Repositories
{
    public interface ILeaveRepo
    {
        List<Leave> GetAllLeaves();
        void AddNewLeave(Leave l);
        void UpdateLeave(Leave l);
        void DeleteLeave(int id);
        Leave GetLeaveById(int id);
    }
}
