using AutoMapper;
using SAASPortal.Core.DTOs;
using SAASPortal.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SAASPortal.Core.Services
{
    public class AssessmentService : IAssessmentService
    {
        private readonly IAssignmentRepository _assignmentRepository;
        private readonly IMapper _mapper;



        public Task<int> CreateAssignmentAsync(AssessmentDto assessmentDto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AssessmentDto>> GetAllAssignmentsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<AssessmentDto> GetAssignmentByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
