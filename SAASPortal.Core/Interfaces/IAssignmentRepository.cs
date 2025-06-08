using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAASPortal.Core.Models;

namespace SAASPortal.Core.Interfaces
{
    public interface IAssignmentRepository
    {
        Task<Assignment> GetByIdAsync(int id);
        //Task<IEnumerable<Assignment>> GetAllAsync();
        //Task<int> CreateAsync(Assignment assignment);
        //Task<bool> UpdateAsync(Assignment assignment);
        //Task<bool> DeleteAsync(int id);
        // Add other custom methods (e.g., GetAssignmentsByCourseId)
    }
}
