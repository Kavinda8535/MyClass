using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDomain.Entities
{
    public class ClassAvailabilityCheck : BaseEntity
    {
        public int CourseId { get; set; }
        public int TeacherId { get; set; }
        public DateTime ClassDateTime { get; set; }
        public Course? Course { get; set; }
        public Teacher? Teacher { get; set; }
    }
}
