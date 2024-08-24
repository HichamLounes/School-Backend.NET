using SchoolProject.Context;
using SchoolProject.Models;

namespace SchoolProject.Repository
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly MyDbContext _myDbContext;
        public TeacherRepository(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }
        public void Create(Teacher teacher)
        {
            _myDbContext.teachers.Add(teacher);
            _myDbContext.SaveChanges();
        }

        public void Delete(int teacherId)
        {
            Teacher teacher = (from teacherObj in _myDbContext.teachers
                               where teacherObj.teacherID == teacherId
                               select teacherObj).FirstOrDefault();
            _myDbContext.teachers.Remove(teacher);
            _myDbContext.SaveChanges();
        }

        public List<Teacher> GetAllTeachers()
        {
            List<Teacher> teacher = (from teachersObj in _myDbContext.teachers
                                     select teachersObj).ToList();
            return teacher;
        }
    }
}
