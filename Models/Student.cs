using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int studentID { get; set; }
        [MaxLength(30)]
        [MinLength(10)]
        public string name { get; set; }
        [Range(5, 18)]
        public int age { get; set; }
        public bool isActive { get; set; }
    }
}
