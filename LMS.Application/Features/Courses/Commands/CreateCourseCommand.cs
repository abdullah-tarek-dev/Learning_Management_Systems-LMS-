using LMS.Application.DTOs.Course;
using MediatR;

namespace LMS.Application.Features.Courses.Commands;

public record CreateCourseCommand(
    CreateCourseDto CourseDto)
    : IRequest<Guid>;