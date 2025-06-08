using Microsoft.Data.SqlClient;
using SAASPortal.Core.DTOs;
using SAASPortal.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAASPortal.Test
{
    public class AssignmentRepositoryTests : IDisposable
    {
        private readonly SqlConnection _connection;
        private readonly AssignmentRepository _repo;

        public AssignmentRepositoryTests()
        {
            _connection = new SqlConnection(/* test connection string */);
            _connection.Open();
            _repo = new AssignmentRepository(_connection);

            // Initialize test database
            InitializeTestDatabase();
        }

        [Fact]
        public async Task CreateAssignment_ValidData_ReturnsId()
        {
            // Arrange
            var assignment = new AssignmentDto { /* test data */ };

            // Act
            var result = await _repo.CreateAssignmentAsync(assignment);

            // Assert
            Assert.True(result > 0);
        }

        public void Dispose()
        {
            _connection.Close();
        }
    }
}
