using Microsoft.EntityFrameworkCore;
using NewArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewArch.Infra.Data.Context
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions options) : base(options)
        { 
        }

        public DbSet<Course> Courses { get; set; }
    }
}
