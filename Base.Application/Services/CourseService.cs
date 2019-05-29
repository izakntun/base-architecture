using Base.Application.Interfaces;
using Base.Application.ViewModels;
using Base.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Base.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = _courseRepository.GetCourses()
            };
        }
    }
}
