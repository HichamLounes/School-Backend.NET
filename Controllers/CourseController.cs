using Microsoft.AspNetCore.Mvc;
using SchoolProject.Models;
using SchoolProject.Repository;

namespace SchoolProject.Controllers
{
    public class CourseController : Controller
    {
        public readonly ICourseRepository _courseRepository;
        public CourseController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        [HttpGet]
        public ActionResult Index()
        {
            List<Course> course = _courseRepository.GetAllCourses();
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Course course)
        {
            _courseRepository.Create(course);
            return View();
        }
        [HttpDelete]
        public ActionResult Delete(int courseId)
        {
            _courseRepository.Delete(courseId);
            return View();
        }
    }
}
