using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static StudLab.Models.Student;

namespace StudLab.Models
{
    public class StudentDbContext : IdentityDbContext<UserEntity,UserRole, int>
    {

        public StudentDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Student { get; set; } = null!;
    }

}
