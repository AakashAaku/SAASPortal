using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SAASPortal.Core.Models
{
    public class Assessment
    {
        [Key]
        public int AssessmentId { get; set; }

        // Foreign key for Submission
        public int SubmissionId { get; set; }

        // Foreign key for Faculty (from Identity User)
        [Required]
        public string FacultyId { get; set; }

        public string? Feedback { get; set; }  // Nullable

        public DateTime AssessmentDate { get; set; } = DateTime.UtcNow;

        // Navigation properties
        [ForeignKey("SubmissionId")]
        public virtual Submission Submission { get; set; }

        [ForeignKey("FacultyId")]
        public virtual ApplicationUser Faculty { get; set; }

        public virtual ICollection<AssessmentScore> Scores { get; set; }
    }
}
