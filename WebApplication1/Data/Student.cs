using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Data
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }
}