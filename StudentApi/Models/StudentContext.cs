using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace StudentApi.Models
{
    public class StudentContext : IdentityDbContext<UserEntity, UserRole, int>
    {
        public StudentContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Student { get; set; } = null!;
    }
}