using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebAppEF_CodeFirst.Models
{
    [Table("tblCourse")]
    public class Course
    {
        [Key]
        public int CourseCode {get; set; }

        [Required(ErrorMessage ="Course Name is must")]
        [Display(Name ="Course Name")]
        [Column("CourseName")]
        [MaxLength(20, ErrorMessage ="Max 20 characters can be added")]
        [MinLength(5, ErrorMessage ="Min 5 characters are needed")]
        public string Name { get; set; }
        [Range(10,30)]
        [Display(Name="Course Duration")]
        [Required(ErrorMessage ="Duratioj is must")]
        public int Duration { get; set; }
        [Required(ErrorMessage ="Des is must")]
        public string Description { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }
    }
}
