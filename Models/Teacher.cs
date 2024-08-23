using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject.Models
{
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int teacherID { get; set; }
        [MaxLength(30)]
        [MinLength(10)]
        public string name { get; set; }
        [Range(27, 70)]
        public int age { get; set; }
        public bool isActive { get; set; }
    }
}
