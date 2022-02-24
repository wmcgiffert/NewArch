using NewArch.Application.Interfaces;
using NewArch.Domain.Interfaces;
using NewArch.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public IEnumerable<CourseVM> GetCourses()
        {
            throw new NotImplementedException();
        }
    }
}
`