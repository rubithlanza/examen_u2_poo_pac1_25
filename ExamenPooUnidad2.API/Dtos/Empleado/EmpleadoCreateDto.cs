using System.ComponentModel.DataAnnotations;

namespace ExamenPooUnidad2.API.Dtos.Empleado
{
    public class EmpleadoCreateDto
    {
        [Display(Name = "Nombre")] 
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El campo {0} debe tener un minimo de {2} y una maximo de {1} caracteres.")]
        public string Nombre { get; set; }

        [Display(Name = "Apellido")] 
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El campo {0} debe tener un minimo de {2} y una maximo de {1} caracteres.")]
        public string Apellido { get; set; }

        [Display(Name = "Documento Nacional de Identidad")] 
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(13, MinimumLength = 13, ErrorMessage = "El campo {0} debe tener un minimo de {2} y una maximo de {1} caracteres.")]
        public string Documento { get; set; }

        public DateTime FechaContratacion { get; set; }



        public string Departamento { get; set; }


        public string PuestoTrabajo { get; set; }



        public int Salario { get; set; }


        public bool Activo { get; set; }
    }
}
