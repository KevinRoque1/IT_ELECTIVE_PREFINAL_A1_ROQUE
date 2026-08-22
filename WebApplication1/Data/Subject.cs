using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Data
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }
        public string SubjectCode { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
    }
}