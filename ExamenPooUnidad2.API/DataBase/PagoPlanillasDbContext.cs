using ExamenPooUnidad2.API.DataBase.Entities;
using Microsoft.EntityFrameworkCore;


namespace ExamenPooUnidad2.API.DataBase
{
    public class PagoPlanillasDbContext : DbContext
    {
        public PagoPlanillasDbContext(DbContextOptions options) : base(options) 
        {
        }

        //Craecion del mapa
        public DbSet<EmpleadoEntity> Empleados { get; set; }
        public DbSet<PlanillaEntity> Planilla { get; set; }
        public DbSet<DetallePlanillaEntity> DetallePlanilla { get;set; }
    }
}
