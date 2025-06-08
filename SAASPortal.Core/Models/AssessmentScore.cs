using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SAASPortal.Core.Models
{
    public class AssessmentScore
    {
        [Key]
        public int ScoreId { get; set; }

        [Required]
        public int AssessmentId { get; set; }

        [Required]
        public int CriteriaId { get; set; }

        [Required]
        [Range(1, 10)]
        public int Score { get; set; }

        [StringLength(255)]
        public string Remarks { get; set; }

        // Navigation properties
        [ForeignKey("AssessmentId")]
        public virtual Assessment Assessment { get; set; }

        [ForeignKey("CriteriaId")]
        public virtual AssessmentCriteria Criteria { get; set; }
    }
}
