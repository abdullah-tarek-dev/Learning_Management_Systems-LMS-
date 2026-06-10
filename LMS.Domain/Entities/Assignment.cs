using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Domain.Common;

namespace LMS.Domain.Entities
{
    public class Assignment : BaseEntity
    {
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public DateTime DueDate { get; set; }

        public Guid CourseId { get; set; }

        // Navigation

        public Course Course { get; set; } = null!;

        public ICollection<Submission> Submissions { get; set; }
            = new List<Submission>();
    }
}
