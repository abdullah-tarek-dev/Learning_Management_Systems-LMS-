namespace LMS.Application.DTOs.Course;

public class CreateCourseDto
{
    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public Guid InstructorId { get; set; }
}