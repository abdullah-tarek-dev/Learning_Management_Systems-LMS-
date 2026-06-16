using LMS.Application.DTOs.Course;
using MediatR;

namespace LMS.Application.Features.Courses.Queries;

public record GetAllCoursesQuery()
    : IRequest<IEnumerable<CourseResponseDto>>;