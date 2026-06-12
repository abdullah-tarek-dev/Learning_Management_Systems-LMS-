namespace LMS.Application.DTOs.Enrollment;

public class CreateEnrollmentDto
{
    public Guid StudentId { get; set; }

    public Guid CourseId { get; set; }
}