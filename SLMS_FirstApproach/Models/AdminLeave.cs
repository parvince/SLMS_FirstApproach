namespace SLMS_FirstApproach.Models
{
    public class AdminLeave
    {
        public int Id { get; set; }
        public int? AdminId { get; set; }
        public int? LeaveId { get; set; }
        public string Status { get; set; }
        public string AdminRemark { get; set; }

        public virtual Admin Admin { get; set; }
        public virtual Leave Leave { get; set; }
        public int AdminLeaveId { get; internal set; }
    }
}
