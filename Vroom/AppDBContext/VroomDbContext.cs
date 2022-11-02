using Microsoft.EntityFrameworkCore;
using Vroom.Models;

namespace Vroom.AppDbContext
{
    public class VroomDbContext : DbContext
    {
        public VroomDbContext(DbContextOptions<VroomDbContext>options) : base(options)
        {

        }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Employee> Employees { get; set; }
        
    }
}
