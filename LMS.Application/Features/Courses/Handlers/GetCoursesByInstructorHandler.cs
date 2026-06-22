
using AutoMapper;
using LMS.Application.DTOs.Course;
using LMS.Application.Features.Courses.Queries;
using LMS.Application.Interfaces;
using MediatR;

namespace LMS.Application.Features.Courses.Handlers
{
    public class GetCoursesByInstructorHandler
        : IRequestHandler<GetCoursesByInstructorQuery, IEnumerable<CourseResponseDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetCoursesByInstructorHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CourseResponseDto>> Handle(
            GetCoursesByInstructorQuery request,
            CancellationToken cancellationToken)
        {
            var courses = await _unitOfWork.Courses
                .GetCoursesByInstructorAsync(request.InstructorId);

            return _mapper.Map<IEnumerable<CourseResponseDto>>(courses);
        }
    }
}
