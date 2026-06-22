using LMS.Application.DTOs.User;
using MediatR;

namespace LMS.Application.Features.Courses.Queries;

public record GetCourseStudentsQuery(Guid CourseId)
    : IRequest<IEnumerable<UserResponseDto>>;