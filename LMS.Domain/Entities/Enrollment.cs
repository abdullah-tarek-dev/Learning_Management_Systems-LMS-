using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Domain.Common;
using LMS.Domain.Enums;

namespace LMS.Domain.Entities
{
    public class Enrollment : BaseEntity
    {
        public Guid StudentId { get; set; }

        public Guid CourseId { get; set; }

        public EnrollmentStatus Status { get; set; }

        public DateTime EnrollmentDate { get; set; }

        // Navigation

        public ApplicationUser Student { get; set; } = null!;

        public Course Course { get; set; } = null!;
    }
}
