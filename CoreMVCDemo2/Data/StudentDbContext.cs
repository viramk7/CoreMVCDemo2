using CoreMVCDemo2.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreMVCDemo2.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<StudentSubjectMapping> StudentSubjectMapping { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<StudentSubjectMapping>().HasKey(a => new { a.StudentId, a.SubjectId });

            base.OnModelCreating(modelBuilder);
        }

    }
}
