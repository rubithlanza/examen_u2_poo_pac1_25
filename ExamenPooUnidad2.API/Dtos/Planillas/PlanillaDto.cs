using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExamenPooUnidad2.API.Dtos.Planillas
{
    public class PlanillaDto
    {
     

        public Guid Id { get; set; }

       
        public string Periodo { get; set; }

    

        public DateTime FechaCreacion { get; set; }



        public DateTime FechaPago { get; set; }

        public string Estado { get; set; }
    }
}
