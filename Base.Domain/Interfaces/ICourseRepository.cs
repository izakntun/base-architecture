using Base.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Base.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
