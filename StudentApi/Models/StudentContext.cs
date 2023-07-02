using Microsoft.EntityFrameworkCore;

namespace StudentApi.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Student { get; set; } = null!;
    }
}