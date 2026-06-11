using LMS.Application.Interfaces;
using LMS.Application.Interfaces.Repositories;
using LMS.Infrastructure.Repositories;

namespace LMS.Infrastructure.Persistence;

public class UnitOfWork : IUnitOfWork
{
    private readonly LMSDbContext _context;

    public IUserRepository Users { get; }

    public ICourseRepository Courses { get; }

    public IEnrollmentRepository Enrollments { get; }

    public IAssignmentRepository Assignments { get; }

    public ISubmissionRepository Submissions { get; }

    public UnitOfWork(LMSDbContext context)
    {
        _context = context;

        Users = new UserRepository(context);
        Courses = new CourseRepository(context);
        Enrollments = new EnrollmentRepository(context);
        Assignments = new AssignmentRepository(context);
        Submissions = new SubmissionRepository(context);
    }

    public async Task<int> SaveChangesAsync(
        CancellationToken cancellationToken = default)
    {
        return await _context.SaveChangesAsync(cancellationToken);
    }
}