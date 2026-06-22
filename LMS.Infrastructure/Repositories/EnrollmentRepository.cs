using LMS.Application.Interfaces.Repositories;
using LMS.Domain.Entities;
using LMS.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace LMS.Infrastructure.Repositories;

public class EnrollmentRepository
    : GenericRepository<Enrollment>,
      IEnrollmentRepository
{
    public EnrollmentRepository(LMSDbContext context)
        : base(context)
    {
    }
    public async Task<IEnumerable<ApplicationUser>>
    GetStudentsByCourseIdAsync(Guid courseId)
    {
        return await _context.Enrollments
            .Where(e => e.CourseId == courseId)
            .Select(e => e.Student)
            .ToListAsync();
    }
}