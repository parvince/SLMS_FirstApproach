using System.Collections.Generic;

namespace SLMS_FirstApproach.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Passwd { get; set; }

        public virtual ICollection<AdminLeave> AdminLeaves { get; set; }

        public int StudentId { get; internal set; }
        public int AdminId { get; internal set; }
    }
}
