using AutoMapper;
using LMS.Application.Features.Courses.Commands;
using LMS.Application.Interfaces;
using LMS.Domain.Entities;
using MediatR;

namespace LMS.Application.Features.Courses.Handlers;

public class CreateCourseHandler
    : IRequestHandler<CreateCourseCommand, Guid>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreateCourseHandler(
        IUnitOfWork unitOfWork,
        IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(
        CreateCourseCommand request,
        CancellationToken cancellationToken)
    {
        var course = _mapper.Map<Course>(
            request.CourseDto);

        course.Id = Guid.NewGuid();
        course.CreatedAt = DateTime.UtcNow;

        await _unitOfWork.Courses
            .AddAsync(course);

        await _unitOfWork
            .SaveChangesAsync(cancellationToken);

        return course.Id;
    }
}