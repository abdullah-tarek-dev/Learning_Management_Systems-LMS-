using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Application.Features.Courses.Commands;
using LMS.Application.Interfaces;
using MediatR;

namespace LMS.Application.Features.Courses.Handlers
{
    public class UpdateCourseHandler
        :IRequestHandler<UpdateCourseCommand,bool>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateCourseHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(
            UpdateCourseCommand request,
            CancellationToken cancellationToken)
        {
            var course = await _unitOfWork.Courses.GetByIdAsync(request.Id);
            if (course == null)
            {
                return false;
            }
            course.Title = request.CourseDto.Title;
            course.Description = request.CourseDto.Description;
            //course.Credits = request.CourseDto.Credits;
            _unitOfWork.Courses.Update(course);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
    }
}

