using System.Collections.Generic;
using System.Linq;
using SLMS_FirstApproach.Models;

namespace SLMS_CodeFirst.Repositories
{
    public class LeaveRepo : ILeaveRepo
    {
        readonly SLMSContext context;
        public LeaveRepo(SLMSContext Context)
        {
            context = Context;
        }
        public void AddNewLeave(Leave l)
        {
            context.Leaves.Add(l);
            context.SaveChanges();
        }

        public void DeleteLeave(int id)
        {
            Leave l = context.Leaves.FirstOrDefault(l => l.LeaveId == id);
            if (l != null)
            {
                context.Leaves.Remove(l);
                context.SaveChanges();
            }
        }

        public List<Leave> GetAllLeaves()
        {
            return context.Leaves.ToList();
        }


        public void UpdateLeave(Leave newLeave)
        {
            Leave l = context.Leaves.FirstOrDefault(l => l.LeaveId == newLeave.LeaveId);
            if (l != null)




            {
                l.Id = newLeave.LeaveId;
                l.StudentId = newLeave.StudentId;
                l.Reason = newLeave.Reason;
                l.Status = newLeave.Status;
                l.Todate = newLeave.Todate;
                l.Fromdate = newLeave.Fromdate;

                context.SaveChanges();

            }
        }

        public Leave GetLeaveById(int id)
        {
            Leave l = context.Leaves.Find(id);
            return l;
        }

        public List<Student> GetAllStudents()
        {
            throw new System.NotImplementedException();
        }

        public void AddNewStudent(Student s)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateEvent(Student e)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteStudent(int id)
        {
            throw new System.NotImplementedException();
        }

        public Student GetStudentById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
