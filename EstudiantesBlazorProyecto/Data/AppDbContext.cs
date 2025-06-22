using Microsoft.EntityFrameworkCore;
using EstudiantesBlazorProyecto.Models;

namespace EstudiantesBlazorProyecto.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Estudiante> Estudiantes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración para campos opcionales (que permiten NULL)
            modelBuilder.Entity<Estudiante>(entity =>
            {
                entity.Property(e => e.DescripcionPersonal)
                      .IsRequired(false); // Marca como opcional

                entity.Property(e => e.TipoMascotas)
                      .IsRequired(false);

                entity.Property(e => e.HorarioComida)
                      .IsRequired(false);
            });

            /* Opcional: Configuración para valores por defecto
            modelBuilder.Entity<Estudiante>()
                .Property(e => e.TieneMascotas)
                .HasDefaultValue(false); */
        }
    }
}