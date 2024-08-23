using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject.Models
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int courseId { get; set; }
        [MaxLength(50)]
        [MinLength(20)]
        public string name { get; set; }
        public int teacherID { get; set; }
        public Teacher teacher { get; set; }

        [Range(0, 20)]
        public int capacity { get; set; }

    }
}
