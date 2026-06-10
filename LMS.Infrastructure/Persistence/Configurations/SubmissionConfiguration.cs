using LMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LMS.Infrastructure.Persistence.Configurations;

public class SubmissionConfiguration
    : IEntityTypeConfiguration<Submission>
{
    public void Configure(EntityTypeBuilder<Submission> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.FileUrl)
            .IsRequired();

        builder.Property(x => x.Grade)
            .HasPrecision(5, 2);

        builder.HasIndex(x => new
        {
            x.StudentId,
            x.AssignmentId
        }).IsUnique();

        builder.HasOne(x => x.Student)
            .WithMany(x => x.Submissions)
            .HasForeignKey(x => x.StudentId);

        builder.HasOne(x => x.Assignment)
            .WithMany(x => x.Submissions)
            .HasForeignKey(x => x.AssignmentId);
    }
}