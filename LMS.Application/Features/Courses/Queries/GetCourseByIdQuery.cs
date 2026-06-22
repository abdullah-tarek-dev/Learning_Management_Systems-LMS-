
using LMS.Application.DTOs.Course;
using MediatR;

namespace LMS.Application.Features.Courses.Queries
{
public record GetCourseByIdQuery(Guid Id)
        : IRequest<CourseResponseDto>;
}
