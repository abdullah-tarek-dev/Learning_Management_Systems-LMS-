using LMS.Application.Interfaces.Repositories;
using LMS.Domain.Entities;
using LMS.Infrastructure.Persistence;

namespace LMS.Infrastructure.Repositories;

public class AssignmentRepository
    : GenericRepository<Assignment>,
      IAssignmentRepository
{
    public AssignmentRepository(LMSDbContext context)
        : base(context)
    {
    }
}