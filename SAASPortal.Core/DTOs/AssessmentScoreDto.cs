using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAASPortal.Core.DTOs
{
    public class AssessmentScoreDto
    {
        public int AssessmentScoreId { get; set; }

        public int AssessmentId { get; set; }

        public string Criterion { get; set; }

        public decimal Score { get; set; }
    }
}
