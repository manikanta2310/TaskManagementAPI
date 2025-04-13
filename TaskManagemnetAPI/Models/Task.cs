using System.ComponentModel.DataAnnotations;

namespace TaskManagemnetAPI.Models
{
    public class Task
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Title { get; set; }

        public string? Description { get; set; }

        public DateTime? DueDate { get; set; }

        public bool IsComplete { get; set; }
    }
}
