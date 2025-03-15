using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenPooUnidad2.API.DataBase.Entities
{
    [Table("empleados")]
    public class EmpleadoEntity 
    {
        [Key]
        [Column("id")]

        public Guid Id { get; set; }

        [Column("nombre")]
        [Required]
        public string Nombre { get; set; }

        [Column("apellido")]
        [Required]

        public string Apellido { get; set; }

        [Column("documento")]
        [Required]
        public string Documento { get; set; }

        [Column("fecha_contratacion")]
        
        public DateTime FechaContratacion { get; set; }


        [Column("departamento")]

        public DateTime Departamento { get; set; }

        [Column("puesto_trabajo")]

        public DateTime PuestoTrabajo { get; set; }

        [Column("salario")]

        public int Salario { get; set; }

        [Column("activo")]

        public bool Activo { get; set; }


     //  public virtual IEnumerable<EmpleadoEntity> DetallePlanilla { get; set; }

    }
}
