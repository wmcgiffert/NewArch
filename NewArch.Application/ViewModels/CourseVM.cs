using NewArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewArch.Application.ViewModels
{
    public class CourseVM
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
