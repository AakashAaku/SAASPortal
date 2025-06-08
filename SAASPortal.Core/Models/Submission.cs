using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SAASPortal.Core.Models
{
    public class Submission
    {
        [Key]
        public int SubmissionId { get; set; }

        [Required]
        public int AssignmentId { get; set; }

        [Required]
        public string StudentId { get; set; }

        [Required]
        [StringLength(255)]
        public string FilePath { get; set; }

        public DateTime SubmissionDate { get; set; } = DateTime.UtcNow;

        public bool LateSubmission { get; set; }

        // Navigation properties
        [ForeignKey("AssignmentId")]
        public virtual Assignment Assignment { get; set; }

        [ForeignKey("StudentId")]
        public virtual ApplicationUser Student { get; set; }

        public virtual Assessment Assessment { get; set; }
    }
}
