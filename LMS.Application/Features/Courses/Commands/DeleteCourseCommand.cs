using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace LMS.Application.Features.Courses.Commands
{
    public record DeleteCourseCommand(Guid Id)
        : IRequest<bool>;
}
