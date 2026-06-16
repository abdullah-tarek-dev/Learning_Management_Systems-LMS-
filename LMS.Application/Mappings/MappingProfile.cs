using AutoMapper;
using LMS.Application.DTOs.Course;
using LMS.Domain.Entities;

namespace LMS.Application.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateCourseDto, Course>();

        CreateMap<Course, CourseResponseDto>();
    }
}