using Base.Domain.Interfaces;
using Base.Domain.Models;
using Base.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Base.Infra.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDBContext _ctx;
        
        public CourseRepository(UniversityDBContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Course> GetCourses()
        {
            return _ctx.Courses;
        }
    }
}
