using LMS.Application.Interfaces.Repositories;
using LMS.Domain.Entities;
using LMS.Infrastructure.Persistence;

namespace LMS.Infrastructure.Repositories;

public class SubmissionRepository
    : GenericRepository<Submission>,
      ISubmissionRepository
{
    public SubmissionRepository(LMSDbContext context)
        : base(context)
    {
    }
}