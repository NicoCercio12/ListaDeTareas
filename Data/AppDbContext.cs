using Microsoft.EntityFrameworkCore;
using ListaDeTareas.Models;

namespace ListaDeTareas.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Tarea> Tareas { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


    }
}
