using AutoMapper;
using SAASPortal.Core.DTOs;
using SAASPortal.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAASPortal.Core.Services
{
    public class AssignmentService : IAssignmentService
    {
        private readonly IAssignmentRepository _assignmentRepository;
        private readonly IMapper _mapper;

        public AssignmentService(
            IAssignmentRepository assignmentRepository,
            IMapper mapper)
        {
            _assignmentRepository = assignmentRepository;
            _mapper = mapper;
        }

        public async Task<AssignmentDto> GetAssignmentByIdAsync(int id)
        {
            var assignment = await _assignmentRepository.GetByIdAsync(id);
            return _mapper.Map<AssignmentDto>(assignment);
        }

        Task<int> IAssignmentService.CreateAssignmentAsync(AssignmentDto assignmentDto)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<AssignmentDto>> IAssignmentService.GetAllAssignmentsAsync()
        {
            throw new NotImplementedException();
        }

        Task<AssignmentDto> IAssignmentService.GetAssignmentByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        // Implement other methods...
    }
}
