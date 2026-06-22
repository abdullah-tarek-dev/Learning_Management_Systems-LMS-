using LMS.Application.Features.Courses.Commands;
using LMS.Application.Interfaces;
using MediatR;

namespace LMS.Application.Features.Courses.Handlers;

public class DeleteCourseHandler
    : IRequestHandler<
        DeleteCourseCommand,
        bool>
{
    private readonly IUnitOfWork _unitOfWork;

    public DeleteCourseHandler(
        IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<bool> Handle(
        DeleteCourseCommand request,
        CancellationToken cancellationToken)
    {
        var course = await _unitOfWork
            .Courses
            .GetByIdAsync(request.Id);

        if (course is null)
            return false;

        _unitOfWork.Courses
            .Delete(course);

        await _unitOfWork
            .SaveChangesAsync(cancellationToken);

        return true;
    }
}