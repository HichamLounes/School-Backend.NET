using Microsoft.AspNetCore.Mvc;
using SchoolProject.Models;
using SchoolProject.Repository;

namespace SchoolProject.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        // GET List of students
        [HttpGet]
        public ActionResult Index()
        {
            List<Student> Stdlist = _studentRepository.GetAllStudents();
            return View();
        }

        //Render the creation view
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student student)
        {
            _studentRepository.Create(student);
            return View();
        }

        [HttpDelete]
        public ActionResult Delete(int studentID)
        {
            _studentRepository.Delete(studentID);
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(int studentID, int courseId)
        {
            _studentRepository.Register(studentID, courseId);
            return View();
        }
    }
}
