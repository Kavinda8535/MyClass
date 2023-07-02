using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDomain.Entities
{
    public class Teacher : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public ICollection<Student>? Students { get; set; }
        public ICollection<ClassAvailabilityCheck>? ClassAvailabilityChecks { get; set; }
    }
}
