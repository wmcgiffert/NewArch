using NewArch.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewArch.Application.Interfaces
{
    public interface ICourseService
    {
        CourseVM GetCourses();
    }
}
