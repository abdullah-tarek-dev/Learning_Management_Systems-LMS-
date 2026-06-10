using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Domain.Common;

namespace LMS.Domain.Entities
{
    public class Course : BaseEntity
    {
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public Guid InstructorId { get; set; }

        // Navigation

        public ApplicationUser Instructor { get; set; } = null!;

        public ICollection<Enrollment> Enrollments { get; set; }
            = new List<Enrollment>();

        public ICollection<Assignment> Assignments { get; set; }
            = new List<Assignment>();
    }
}
