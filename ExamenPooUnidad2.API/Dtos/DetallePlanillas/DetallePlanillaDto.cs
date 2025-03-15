using ExamenPooUnidad2.API.DataBase.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExamenPooUnidad2.API.Dtos.DetallePlanillas
{
    public class DetallePlanillaDto
    {

        public Guid? Id { get; set; }


        public PlanillaEntity Planilla { get; set; }

  
        public EmpleadoEntity Empleado { get; set; }

        public decimal SalarioBase { get; set; }

        public decimal HorasExtras { get; set; }

        public decimal MontoHorasExtras { get; set; }

        public decimal Bonificaciones { get; set; }

        public decimal Deduciones { get; set; }

        public decimal SalarioNeto { get; set; }

        public string Comentarios { get; set; }
    }
}
