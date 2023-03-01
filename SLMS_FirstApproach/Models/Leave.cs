using System.Collections.Generic;
using System;

namespace SLMS_FirstApproach.Models
{
    public class Leave
    {
        public int Id { get; set; }
        public int? StudentId { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
        public DateTime? Todate { get; set; }
        public DateTime? Fromdate { get; set; }

        public virtual Student Student { get; set; }
        public virtual ICollection<AdminLeave> AdminLeaves { get; set; }
        public int LeaveId { get; internal set; }
    }
}
