using SAASPortal.Core.Interfaces;
using SAASPortal.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SAASPortal.Infrastructure.Repositories
{
    public class AssessmentRepository : IAssessmentRepository
    {
        public Task<int> CreateAsync(Assessment assignment)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Assessment>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Assessment> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Assessment assignment)
        {
            throw new NotImplementedException();
        }
    }
}
