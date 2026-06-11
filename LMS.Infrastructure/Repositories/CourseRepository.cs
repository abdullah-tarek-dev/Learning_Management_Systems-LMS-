using LMS.Application.Interfaces.Repositories;
using LMS.Domain.Entities;
using LMS.Infrastructure.Persistence;

namespace LMS.Infrastructure.Repositories;

public class CourseRepository
    : GenericRepository<Course>,
      ICourseRepository
{
    public CourseRepository(LMSDbContext context)
        : base(context)
    {
    }
}