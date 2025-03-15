using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenPooUnidad2.API.DataBase.Entities
{
    [Table("planilla")]
    public class PlanillaEntity
    {
        [Key]
        [Column("id")]

        public Guid Id { get; set; }

        [Column("periodo")]
        [Required]
        public string Periodo { get; set; }

        [Column("fecha_creacion")]

        public DateTime FechaCreacion { get; set; }

        [Column("fecha_pago")]

        public DateTime FechaPago { get; set; }

        [Column("estado")]
        public string Estado { get; set; }

      //public virtual IEnumerable<PlanillaEntity> DetallePlanilla{ get; set; }
    }
}
