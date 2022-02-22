using NewArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewArch.Domain.Interfaces
{
    internal interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
