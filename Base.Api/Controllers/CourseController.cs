﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Base.Application.Interfaces;
using Base.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Base.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CourseViewModel courseViewModel)
        {
            _courseService.Create(courseViewModel);
            return Ok(courseViewModel);
        }
    }
}
