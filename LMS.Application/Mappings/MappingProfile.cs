using AutoMapper;
using LMS.Application.DTOs.Course;
using LMS.Application.DTOs.User;
using LMS.Domain.Entities;
namespace LMS.Application.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateCourseDto, Course>();

        CreateMap<Course, CourseResponseDto>();
        CreateMap<ApplicationUser, UserResponseDto>();
    }
}