using Microsoft.Data.SqlClient;
using Moq;
using SAASPortal.Core.DTOs;
using SAASPortal.Core.Interfaces;
using SAASPortal.Core.Services;
using SAASPortal.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAASPortal.Test
{
    public class AssignmentServiceTests
    {
        private readonly Mock<IAssignmentRepository> _mockRepo;
        private readonly AssignmentService _service;

        public AssignmentServiceTests()
        {
            _mockRepo = new Mock<IAssignmentRepository>();
            _service = new AssignmentService(_mockRepo.Object);
        }

        [Fact]
        public async Task CreateAssignment_ValidData_ReturnsAssignmentId()
        {
            // Arrange
            var assignmentDto = new AssignmentDto { /* valid data */ };
            _mockRepo.Setup(r => r.CreateAssignmentAsync(assignmentDto))
                    .ReturnsAsync(1);

            // Act
            var result = await _service.CreateAssignmentAsync(assignmentDto);

            // Assert
            Assert.Equal(1, result);
            _mockRepo.Verify(r => r.CreateAssignmentAsync(assignmentDto), Times.Once);
        }
    }

   
}
