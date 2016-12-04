using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CodeFirstApproach.Models
{
    public class CodeFirstApproachContext : DbContext
    {
        // value provided in base() will be used as database name to create
        public CodeFirstApproachContext() : base("CodeFirstApproach") {}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Removes pluralization on table names
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Creating a one-to-zero relationship using Fluent API
            // Where, FluentStudent does not require FluentStudentAddress wile saving/updating, but
            // FluentStudentAddress requires FluentStudent while saving/updating 
            //modelBuilder.Entity<FluentStudent>()
            //   .HasOptional(fs => fs.FluentStudentAddress)
            //   .WithRequired(fad => fad.FluentStudent);

            // Creating a one-to-one relationship using Fluent API
            // Where, FluentStudent require FluentStudentAddress wile saving/updating, and
            // FluentStudentAddress requires FluentStudent while saving/updating 
            modelBuilder.Entity<FluentStudent>()
                .HasRequired(fs => fs.FluentStudentAddress)
                .WithRequiredPrincipal(fad => fad.FluentStudent);

            //Creating a One-to-Many relationship using Fluent API 
            //modelBuilder.Entity<FluentStudent>()
            //            .HasRequired<FluentStudentAddress>(s => s.FluentStudentAddress)
            //            .WithMany(s => s.FluentStudent)
            //            .HasForeignKey(s => s.ID);

            //Creating a Many-to-Many relationship using Fluent API 
            //modelBuilder.Entity<Student>()
            //   .HasMany<Course>(s => s.Courses)
            //   .WithMany(c => c.Students)
            //   .Map(cs =>
            //   {
            //       cs.MapLeftKey("StudentRefId");
            //       cs.MapRightKey("CourseRefId");
            //       cs.ToTable("StudentCourse");
            //   });
        }

        public DbSet<Student> Student { get; set; }

        public DbSet<StudentAddress> StudentAddress { get; set; }

        public DbSet<FluentStudent> FluentStudent { get; set; }

        public DbSet<FluentStudentAddress> FluentStudentAddress { get; set; }
    }
}