using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace SLMS_FirstApproach.Models
{
    public class SLMSContext: DbContext
    {
        public SLMSContext(DbContextOptions<SLMSContext> options) : base(options)
        {
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdminLeave> AdminLeaves { get; set; }
        public DbSet<Leave> Leaves { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
