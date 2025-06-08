using System;

namespace SAASPortal.Core.DTOs
{
    public class AssignmentDto
    {
        public int AssignmentId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DueDate { get; set; }

        public string? FilePath { get; set; }

        public DateTime CreatedDate { get; set; }

        public int CourseId { get; set; }

        public string? CourseName { get; set; }
    }
}
