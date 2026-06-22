using LMS.Domain.Entities;

namespace LMS.Application.Interfaces.Repositories;

public interface ICourseRepository
    : IGenericRepository<Course>
{
    Task<IEnumerable<Course>> GetCoursesByInstructorAsync(
    Guid instructorId);
}