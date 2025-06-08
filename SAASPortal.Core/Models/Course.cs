using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SAASPortal.Core.Models
{
    public  class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        [StringLength(100)]
        public string CourseName { get; set; }

        [Required]
        [StringLength(20)]
        public string CourseCode { get; set; }

        // Foreign key for Faculty (from Identity User)
        [Required]
        public string FacultyId { get; set; }

        // Navigation properties
        [ForeignKey("FacultyId")]
        public virtual ApplicationUser Faculty { get; set; }

        public virtual ICollection<Assignment> Assignments { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
