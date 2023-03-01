using System.Collections.Generic;

namespace SLMS_FirstApproach.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Parentphone { get; set; }

        public virtual ICollection<Leave> Leaves { get; set; }
        public int StudentId { get; internal set; }
    }
}
