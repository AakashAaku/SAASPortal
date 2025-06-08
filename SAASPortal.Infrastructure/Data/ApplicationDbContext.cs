using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SAASPortal.Core.Models;

namespace SAASPortal.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Submission> Submissions { get; set; }
        public DbSet<AssessmentScore> AssessmentScores { get; set; }
        public DbSet<AssessmentCriteria> AssessmentCriterias { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Configure relationships
            builder.Entity<Assignment>()
                .HasOne(a => a.Course)
                .WithMany(c => c.Assignments)
                .HasForeignKey(a => a.CourseId);

            // Add other configurations as needed...
        }
    }
}
