using Microsoft.EntityFrameworkCore;
using College.Model.Models;
using System.Linq;

namespace College.Infrastructure.DB
{
    public class CollegeAppContext : DbContext
    {
        public CollegeAppContext(DbContextOptions<CollegeAppContext> options) : base(options) {}
        
        public DbSet<CollegeInstitution> CollegeInstitutions { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Executor> Executors { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grade>()
                .HasKey(g => new { g.StudentId, g.CourseId});
            modelBuilder.Entity<Grade>()
                .HasOne(g => g.Student)
                .WithMany(g => g.Grades)
                .HasForeignKey(g => g.StudentId);
            modelBuilder.Entity<Grade>()
                .HasOne(g => g.Course)
                .WithMany(g => g.Grades)
                .HasForeignKey(g => g.CourseId);

             var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

                foreach (var fk in cascadeFKs)
                    fk.DeleteBehavior = DeleteBehavior.Restrict;

             base.OnModelCreating(modelBuilder);


        }

            



    }
}