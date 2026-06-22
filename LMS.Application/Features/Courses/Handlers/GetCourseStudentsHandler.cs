using AutoMapper;
using LMS.Application.DTOs.User;
using LMS.Application.Features.Courses.Queries;
using LMS.Application.Interfaces;
using MediatR;

namespace LMS.Application.Features.Courses.Handlers;

public class GetCourseStudentsHandler
    : IRequestHandler<
        GetCourseStudentsQuery,
        IEnumerable<UserResponseDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetCourseStudentsHandler(
        IUnitOfWork unitOfWork,
        IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<UserResponseDto>>
        Handle(
            GetCourseStudentsQuery request,
            CancellationToken cancellationToken)
    {
        var students = await _unitOfWork
            .Enrollments
            .GetStudentsByCourseIdAsync(
                request.CourseId);

        return _mapper.Map<
            IEnumerable<UserResponseDto>>(students);
    }
}