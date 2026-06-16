
using LMS.Application.DTOs.Course;
using LMS.Application.Features.Courses.Queries;
using LMS.Application.Interfaces;
using MediatR;

namespace LMS.Application.Features.Courses.Handlers
{
    public class GetCoursesByInstructorHandler
        : IRequestHandler<GetCoursesByInstructorQuery, IEnumerable<CourseResponseDto>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper _mapper;
    }
}
