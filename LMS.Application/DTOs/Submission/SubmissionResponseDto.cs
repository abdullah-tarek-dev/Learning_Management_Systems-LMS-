namespace LMS.Application.DTOs.Submission;

public class SubmissionResponseDto
{
    public Guid Id { get; set; }

    public Guid AssignmentId { get; set; }

    public Guid StudentId { get; set; }

    public string FileUrl { get; set; } = string.Empty;

    public DateTime SubmittedAt { get; set; }

    public decimal? Grade { get; set; }

    public string? Feedback { get; set; }
}