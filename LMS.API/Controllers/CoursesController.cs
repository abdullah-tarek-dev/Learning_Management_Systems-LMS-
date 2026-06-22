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

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var course = await _mediator.Send(
            new GetCourseByIdQuery(id));

        if (course is null)
            return NotFound();

        return Ok(course);
    }

    [HttpGet("instructor/{instructorId:guid}")]
    public async Task<IActionResult> GetByInstructor(
        Guid instructorId)
    {
        var courses = await _mediator.Send(
            new GetCoursesByInstructorQuery(instructorId));

        return Ok(courses);
    }

    [HttpPost]
    public async Task<IActionResult> Create(
        CreateCourseDto dto)
    {
        var courseId = await _mediator.Send(
            new CreateCourseCommand(dto));

        return CreatedAtAction(
            nameof(GetById),
            new { id = courseId },
            courseId);
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Update(
        Guid id,
        UpdateCourseDto dto)
    {
        var result = await _mediator.Send(
            new UpdateCourseCommand(id, dto));

        if (!result)
            return NotFound();

        return NoContent();
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _mediator.Send(
            new DeleteCourseCommand(id));

        if (!result)
            return NotFound();

        return NoContent();
    }
    [HttpGet("{id:guid}/students")]
    public async Task<IActionResult> GetStudents(
    Guid id)
    {
        var students = await _mediator.Send(
            new GetCourseStudentsQuery(id));

        return Ok(students);
    }
}