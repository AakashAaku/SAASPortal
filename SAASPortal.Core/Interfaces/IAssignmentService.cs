using SAASPortal.Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SAASPortal.Core.Interfaces
{
    public interface IAssignmentService
    {
        Task<AssignmentDto> GetAssignmentByIdAsync(int id);
        Task<IEnumerable<AssignmentDto>> GetAllAssignmentsAsync();
        Task<int> CreateAssignmentAsync(AssignmentDto assignmentDto);
        // Other business methods...
    }
}
