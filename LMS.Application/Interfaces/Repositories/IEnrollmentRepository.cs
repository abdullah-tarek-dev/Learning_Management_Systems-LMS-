using LMS.Domain.Entities;

namespace LMS.Application.Interfaces.Repositories;

public interface IEnrollmentRepository
    : IGenericRepository<Enrollment>
{
    Task<IEnumerable<ApplicationUser>>
    GetStudentsByCourseIdAsync(Guid courseId);
}