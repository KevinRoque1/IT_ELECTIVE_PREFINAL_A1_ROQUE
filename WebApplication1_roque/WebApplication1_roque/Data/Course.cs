using System.ComponentModel.DataAnnotations;

namespace WebApplication1_roque.Data
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        [MaxLength(20)]
        public string CourseCode { get; set; } = string.Empty;

        [Required]
        [MaxLength(150)]
        public string CourseName { get; set; } = string.Empty;

        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;
    }
}
