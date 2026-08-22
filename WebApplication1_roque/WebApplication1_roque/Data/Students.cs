using System.ComponentModel.DataAnnotations;

namespace WebApplication1_roque.Data
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        [Required]
        public string Lrn { get; set; } = string.Empty;

    }
}

