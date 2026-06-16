using FluentValidation;
using LMS.Application.DTOs.Course;

namespace LMS.Application.Features.Courses.Validators;

public class CreateCourseValidator
    : AbstractValidator<CreateCourseDto>
{
    public CreateCourseValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty()
            .MaximumLength(200);

        RuleFor(x => x.Description)
            .NotEmpty();

        RuleFor(x => x.InstructorId)
            .NotEmpty();
    }
}