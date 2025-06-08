using SAASPortal.Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SAASPortal.Core.Interfaces
{
    public interface IAssessmentService
    {
        Task<AssessmentDto> GetAssignmentByIdAsync(int id);
        Task<IEnumerable<AssessmentDto>> GetAllAssignmentsAsync();
        Task<int> CreateAssignmentAsync(AssessmentDto assessmentDto);
    }
}
