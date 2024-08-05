using MagicVilla_API.modelos;
using Microsoft.EntityFrameworkCore; 

namespace MagicVilla_API.Datos
{
    public   class AplicationDBContext: DbContext
    {

        public AplicationDBContext(DbContextOptions<AplicationDBContext> options) :base(options)
        {
            
        }


        public DbSet<Villa> Villas  { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa() { Id = 1, Nombre = "Villa Real", Detalle = "Explicación de la villa", ImagenURL = "", Ocupantes = 5, MetrosCuadrados = 120, Tarifa = 120, Amenidad = "", FechaCreacion = DateTime.Now, FechaActualizacion = DateTime.Now },
                new Villa() { Id = 2, Nombre = "Villa Segunda", Detalle = "Explicación de la degunda", ImagenURL = "", Ocupantes = 3, MetrosCuadrados = 110, Tarifa = 100, Amenidad = "", FechaCreacion = DateTime.Now, FechaActualizacion = DateTime.Now }

                );
        }

    }
}