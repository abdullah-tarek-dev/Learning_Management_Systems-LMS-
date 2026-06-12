namespace LMS.Application.DTOs.Submission;

public class CreateSubmissionDto
{
    public Guid AssignmentId { get; set; }

    public Guid StudentId { get; set; }

    public string FileUrl { get; set; } = string.Empty;
}