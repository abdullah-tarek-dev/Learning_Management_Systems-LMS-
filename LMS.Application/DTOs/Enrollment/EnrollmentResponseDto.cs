using LMS.Domain.Enums;

namespace LMS.Application.DTOs.Enrollment;

public class EnrollmentResponseDto
{
    public Guid Id { get; set; }

    public Guid StudentId { get; set; }

    public Guid CourseId { get; set; }

    public EnrollmentStatus Status { get; set; }

    public DateTime EnrollmentDate { get; set; }
}