using Microsoft.AspNetCore.Mvc;

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

        public ViewResult Create()
        {
            return View();
        }
    }
}
