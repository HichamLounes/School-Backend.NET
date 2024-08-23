using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject.Models
{
    public class Registration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int studentCourseId { get; set; }

        public int courseId { get; set; }
        public Course course { get; set; }
        public int studentID { get; set; }
        public Student student { get; set; }
    }
}
