using Microsoft.AspNetCore.Mvc;
using SchoolProject.Models;

namespace SchoolProject.Controllers
{
    public class StudentController : Controller
    {
        // GET List of students
        [HttpGet]
        public ActionResult Index()
        {

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
            return View();
        }

        [HttpDelete]
        public ActionResult Delete(int studentID)
        {
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
            return View();
        }
    }
}
