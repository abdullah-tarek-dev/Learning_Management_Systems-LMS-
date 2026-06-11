using LMS.Application.Interfaces.Repositories;

namespace LMS.Application.Interfaces;

public interface IUnitOfWork
{
    IUserRepository Users { get; }

    ICourseRepository Courses { get; }

    IEnrollmentRepository Enrollments { get; }

    IAssignmentRepository Assignments { get; }

    ISubmissionRepository Submissions { get; }

    Task<int> SaveChangesAsync(
        CancellationToken cancellationToken = default);
}