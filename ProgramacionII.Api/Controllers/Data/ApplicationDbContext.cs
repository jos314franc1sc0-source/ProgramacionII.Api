using Microsoft.EntityFrameworkCore;
using ProgramacionII.Api.Controllers.Models;

namespace ProgramacionII.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Miembro> Miembros { get; set; }
    }
}
