using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Application.DTOs.Course;
using MediatR;

namespace LMS.Application.Features.Courses.Commands
{
    //public record UpdateCourseCommand(
    //    Guid Id,
    //    string Title,
    //    string Description,
    //    Guid InstructorId)
    //    : IRequest;
    //}
    public record UpdateCourseCommand(
        Guid Id,
        UpdateCourseDto CourseDto)
        : IRequest<bool>;
}