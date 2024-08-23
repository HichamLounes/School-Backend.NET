using SchoolProject.Context;
using SchoolProject.Models;

namespace SchoolProject.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly MyDbContext _myDbconnection;

        public StudentRepository(MyDbContext myDbconnection)
        {
            _myDbconnection = myDbconnection;
        }

        public List<Student> GetAllStudents()
        {
            try
            {
                List<Student> students = (from stdsOBJ in _myDbconnection.Students
                                          select stdsOBJ).ToList();
                return students;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void Create(Student student)
        {
            try
            {
                _myDbconnection.Students.Add(student);
                _myDbconnection.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void Delete(int ID)
        {
            Student student = (from stdOBJ in _myDbconnection.Students
                               where stdOBJ.studentID == ID
                               select stdOBJ).FirstOrDefault();
            _myDbconnection.Students.Remove(student);
            _myDbconnection.SaveChanges();
        }

        public void Register(int IdS, int IdC)
        {
            _myDbconnection.registrations.Add(new Registration
            {
                courseId = IdC,
                studentID = IdS
            });
            _myDbconnection.SaveChanges();
        }
    }
}
