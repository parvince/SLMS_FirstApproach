using System.Collections.Generic;
using System.Linq;
using SLMS_FirstApproach.Models;
using System;

namespace SLMS_CodeFirst.Repositories
{
    public class AdminLeaveRepo : IAdminLeaveRepo
    {
        readonly SLMSContext context;
        private object newAdminLeave;

        public AdminLeaveRepo(SLMSContext Context)
        {
            context = Context;
        }
        public void AddNewAdminLeave(AdminLeave a)
        {
            context.AdminLeaves.Add(a);
            context.SaveChanges();
        }

        public void AddNewAdminLeave(Student s)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteAdminLeave(int id)
        {
            AdminLeave a = context.AdminLeaves.FirstOrDefault(a => a.AdminLeaveId == id);
            if (a != null)
            {
                context.AdminLeaves.Remove(a);
                context.SaveChanges();
            }
        }


        public List<AdminLeave> GetAllAdminLeaves()
        {
            return context.AdminLeaves.ToList();
        }

        public List<AdminLeave> GetAllAdminLeave()
        {
            throw new System.NotImplementedException();
        }

        public AdminLeave GetAdminLeaveById(int id)
        {
            throw new System.NotImplementedException();
        }


        public void UpdateAdminLeave(AdminLeave newAdminLeave)
        {
            AdminLeave a = context.AdminLeaves.FirstOrDefault(a => a.AdminLeaveId == newAdminLeave.AdminLeaveId);
            if (a != null)
            {
                a.Id = newAdminLeave.Id;
                a.AdminId = newAdminLeave.AdminId;
                a.LeaveId = newAdminLeave.LeaveId;
                a.Status = newAdminLeave.Status;
                a.AdminRemark = newAdminLeave.AdminRemark;
                context.SaveChanges();

            }
        }

        public void UpdateEvent(AdminLeave a)
        {
            throw new System.NotImplementedException();
        }



    }
}