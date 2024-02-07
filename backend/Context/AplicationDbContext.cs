using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Context
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<Tareas> Tareas { get; set; }
    }
}
