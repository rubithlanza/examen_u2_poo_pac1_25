using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExamenPooUnidad2.API.Dtos.Empleado
{
    public class EmpleadoDto
    {
      

        public Guid Id { get; set; }

     
        public string Nombre { get; set; }

  

        public string Apellido { get; set; }

    
        public string Documento { get; set; }



        public DateTime FechaContratacion { get; set; }



        public string Departamento { get; set; }


        public string PuestoTrabajo { get; set; }

     

        public int Salario { get; set; }

   
        public bool Activo { get; set; }
    }
}
