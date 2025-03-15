using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenPooUnidad2.API.DataBase.Entities
{
    [Table("detalle_planilla")]
    public class DetallePlanillaEntity

    {
        [Key]
        [Column("id")]
        public Guid?Id { get; set; }

        ////Relacion con la tabla planilla  
        //[Column("planilla_id")]

        //public int PlanillaId { get; set; }

        //[ForeignKey(nameof(PlanillaId))]
        //public virtual PlanillaEntity Planilla { get; set; }
        [ForeignKey("planilla_id")]
        public PlanillaEntity Planilla { get; set; }

        // Relacion con la tabla Empleados
        //[Column("empleado_id")]


        //public int EmpleadoId { get; set; }

        //[ForeignKey(nameof(EmpleadoId))]

        //public virtual EmpleadoEntity Empleado { get; set; }
        [ForeignKey("empleado_id")]

        public EmpleadoEntity Empleado { get; set; }

        [Column("salario_base")]
        public decimal SalarioBase { get; set; }

        [Column("horas_extras")]
        public decimal HorasExtras {  get; set; }

        [Column("monto_horas_extras")]

        public decimal MontoHorasExtras { get; set; }

        [Column("bonificaciones")]
        public decimal Bonificaciones { get; set; }

        [Column("deduciones")]
        public decimal Deduciones { get; set; }

        [Column("salario_neto")]
        public decimal SalarioNeto {  get; set; }

        [Column("comentarios")]
        public string Comentarios {  get; set; }
    }
}
