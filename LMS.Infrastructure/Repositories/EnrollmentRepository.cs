using LMS.Application.Interfaces.Repositories;
using LMS.Domain.Entities;
using LMS.Infrastructure.Persistence;

namespace LMS.Infrastructure.Repositories;

public class EnrollmentRepository
    : GenericRepository<Enrollment>,
      IEnrollmentRepository
{
    public EnrollmentRepository(LMSDbContext context)
        : base(context)
    {
    }
}