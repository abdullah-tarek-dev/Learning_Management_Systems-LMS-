using AutoMapper;
using LMS.Application.DTOs.Course;
using LMS.Application.Features.Courses.Queries;
using LMS.Application.Interfaces;
using MediatR;

namespace LMS.Application.Features.Courses.Handlers;

public class GetAllCoursesHandler
    : IRequestHandler<
        GetAllCoursesQuery,
        IEnumerable<CourseResponseDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetAllCoursesHandler(
        IUnitOfWork unitOfWork,
        IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<CourseResponseDto>> Handle(
        GetAllCoursesQuery request,
        CancellationToken cancellationToken)
    {
        var courses = await _unitOfWork
            .Courses
            .GetAllAsync();

        return _mapper.Map<
            IEnumerable<CourseResponseDto>>(courses);
    }
}