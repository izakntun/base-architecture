﻿using Base.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Base.Infra.Data.Context
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
    }
}
