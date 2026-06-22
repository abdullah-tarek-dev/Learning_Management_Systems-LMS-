using LMS.Application.Interfaces.Repositories;
using LMS.Domain.Entities;
using LMS.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace LMS.Infrastructure.Repositories;

public class CourseRepository
    : GenericRepository<Course>,
      ICourseRepository
{
    public CourseRepository(LMSDbContext context)
        : base(context)
    {
    }
    public async Task<IEnumerable<Course>>
    GetCoursesByInstructorAsync(
        Guid instructorId)
    {
        return await _context.Courses
            .Where(c => c.InstructorId == instructorId)
            .ToListAsync();
    }
}