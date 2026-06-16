using LMS.Application.DTOs.Course;
using LMS.Application.Features.Courses.Commands;
using LMS.Application.Features.Courses.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LMS.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CoursesController : ControllerBase
{
    private readonly IMediator _mediator;

    public CoursesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var courses = await _mediator.Send(
            new GetAllCoursesQuery());

        return Ok(courses);
    }

    [HttpPost]
    public async Task<IActionResult> Create(
        CreateCourseDto dto)
    {
        var courseId = await _mediator.Send(
            new CreateCourseCommand(dto));

        return Ok(courseId);
    }
}