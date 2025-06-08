using System;
using System.ComponentModel.DataAnnotations;

namespace SAASPortal.Core.Models
{
    public class AssessmentCriteria
    {
        [Key]
        public int CriteriaId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Range(1, 100)]
        public int MaxScore { get; set; } = 10;
    }
}
