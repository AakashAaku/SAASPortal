using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SAASPortal.Core.Models
{
    public class Assignment
    {
        [Key]
        public int AssignmentId { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        [StringLength(255)]
        public string? FilePath { get; set; }  // Nullable if file upload is optional

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        // Foreign key for Course
        public int CourseId { get; set; }

        // Navigation properties
        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }

        public virtual ICollection<Submission> Submissions { get; set; }
    }
}
