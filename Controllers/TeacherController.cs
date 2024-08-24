using Microsoft.AspNetCore.Mvc;
using SchoolProject.Context;
using SchoolProject.Models;
using SchoolProject.Repository;

namespace SchoolProject.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<Teacher> teachers = _teacherRepository.GetAllTeachers();
            return View();
        }
        [HttpGet]
        public ViewResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Teacher teacher)
        {
            if (teacher != null)
            {
                _teacherRepository.Create(teacher);
            }

            return View();
        }
        [HttpDelete]
        public ActionResult Delete(int teacherId)
        {
            if (teacherId > 0)
            {
                _teacherRepository.Delete(teacherId);
            }
            return View();
        }
    }
}
