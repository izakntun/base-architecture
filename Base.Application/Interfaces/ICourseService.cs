using Base.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Base.Application.Interfaces
{
    public interface ICourseService
    {
        CourseViewModel GetCourses();
    }
}
