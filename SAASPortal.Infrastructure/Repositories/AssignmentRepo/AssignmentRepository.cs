using Dapper;
using SAASPortal.Core.Interfaces;
using SAASPortal.Core.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAASPortal.Infrastructure.Repositories
{
    public class AssignmentRepository : IAssignmentRepository
    {
        private readonly IDbConnection _db;

        public AssignmentRepository(IDbConnection db)
        {
            _db = db;
        }

        //public Task<int> CreateAsync(Assignment assignment)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<bool> DeleteAsync(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IEnumerable<Assignment>> GetAllAsync()
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<Assignment> GetByIdAsync(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@AssignmentId", id);

            return await _db.QuerySingleOrDefaultAsync<Assignment>(
                "sp_GetAssignmentById",
                parameters,
                commandType: CommandType.StoredProcedure);
        }

        //public Task<bool> UpdateAsync(Assignment assignment)
        //{
        //    throw new NotImplementedException();
        //}

        // Implement other methods...
    }
}
