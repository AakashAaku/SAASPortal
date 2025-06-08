using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAASPortal.Core.DTOs
{
    public class AssessmentDto
    {
        public int AssessmentId { get; set; }

        public int SubmissionId { get; set; }

        public string FacultyId { get; set; }

        public string? Feedback { get; set; }

        public DateTime AssessmentDate { get; set; }

        // Optional: Extra data you might want to include
        public string? FacultyName { get; set; } // e.g., from ApplicationUser

        public List<AssessmentScoreDto>? Scores { get; set; }
    }
}
