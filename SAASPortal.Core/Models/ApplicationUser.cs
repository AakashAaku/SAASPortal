using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace SAASPortal.Core.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Navigation properties
        public virtual ICollection<Course> CoursesTeaching { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<Submission> Submissions { get; set; }
        public virtual ICollection<Assessment> Assessments { get; set; }


    }
}
