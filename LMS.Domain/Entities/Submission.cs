using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Domain.Common;

namespace LMS.Domain.Entities
{
    public class Submission : BaseEntity
    {
        public Guid AssignmentId { get; set; }

        public Guid StudentId { get; set; }

        public string FileUrl { get; set; } = string.Empty;

        public DateTime SubmittedAt { get; set; }

        public decimal? Grade { get; set; }

        public string? Feedback { get; set; }

        // Navigation

        public Assignment Assignment { get; set; } = null!;

        public ApplicationUser Student { get; set; } = null!;
    }
}
