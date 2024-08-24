using SchoolProject.Context;
using SchoolProject.Models;

namespace SchoolProject.Repository
{
    public class CourseRepository : ICourseRepository
    {
        public readonly MyDbContext _myDbContext;
        public CourseRepository(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        public void Create(Course course)
        {
            _myDbContext.courses.Add(course);
            _myDbContext.SaveChanges();
        }

        public void Detach(int courseId)
        {
            Course course = (from courseObj in _myDbContext.courses
                             where courseObj.courseId == courseId
                             select courseObj).FirstOrDefault();
            _myDbContext.courses.Remove(course);
            _myDbContext.SaveChanges();
        }

        public List<Course> GetAllCourses()
        {
            List<Course> courses = (from coursesObj in _myDbContext.courses
                                    select coursesObj).ToList();
            return courses;
        }
    }
}
