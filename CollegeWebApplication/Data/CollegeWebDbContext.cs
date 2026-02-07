using CollegeWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace CollegeWebApplication.Data
{
    public class CollegeWebDbContext : DbContext
    {
        public CollegeWebDbContext(DbContextOptions<CollegeWebDbContext> options) : base(options)
        {

        }
        public DbSet<StudentInfo> StudentInfo { get; set; }
    }
}
