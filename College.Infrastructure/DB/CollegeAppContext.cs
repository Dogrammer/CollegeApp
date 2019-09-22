using Microsoft.EntityFrameworkCore;
using College.Model.Models;

namespace College.Infrastructure.DB
{
    public class CollegeAppContext : DbContext
    {
        public CollegeAppContext(DbContextOptions<CollegeAppContext> options) : base(options) {}
        
        public DbSet<CollegeInstitution> CollegeInstitutions { get; set; }
    }
}