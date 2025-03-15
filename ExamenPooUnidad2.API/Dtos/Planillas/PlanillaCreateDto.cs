namespace ExamenPooUnidad2.API.Dtos.Planillas
{
    public class PlanillaCreateDto
    {
        public Guid Id { get; set; }


        public string Periodo { get; set; }



        public DateTime FechaCreacion { get; set; }



        public DateTime FechaPago { get; set; }

        public string Estado { get; set; }
    }
}
