using FluentValidation;
using LMS.Application.DTOs.Course;

namespace LMS.Application.Features.Courses.Validators;

public class UpdateCourseValidator
    : AbstractValidator<UpdateCourseDto>
{
    public UpdateCourseValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty()
            .MaximumLength(200);

        RuleFor(x => x.Description)
            .NotEmpty();
    }
}