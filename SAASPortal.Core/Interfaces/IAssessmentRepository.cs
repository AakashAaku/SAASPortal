using SAASPortal.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAASPortal.Core.Interfaces
{
    public interface IAssessmentRepository
    {
        Task<Assessment> GetByIdAsync(int id);
        Task<IEnumerable<Assessment>> GetAllAsync();
        Task<int> CreateAsync(Assessment assignment);
        Task<bool> UpdateAsync(Assessment assignment);
        Task<bool> DeleteAsync(int id);
    }
}
