using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Data
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; } = string.Empty;
    }
}