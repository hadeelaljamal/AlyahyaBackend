using Microsoft.EntityFrameworkCore;

namespace AlyahyaBackend.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<FamilyMember> FamilyMembers { get; set; }
    }
}
