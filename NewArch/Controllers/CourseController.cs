using Microsoft.AspNetCore.Mvc;
using NewArch.Application.Interfaces;
using NewArch.Application.ViewModels;

namespace NewArch.MVC.Controllers
{
    public class CourseController : Controller
    {
        private ICourseService _courseService;


        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IActionResult Index()
        {
            CourseVM model = _courseService.GetCourses();
            return View(model);
        }
    }
}
