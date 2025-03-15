namespace ExamenPooUnidad2.API.Dtos.DetallePlanillas
{
    public class DetallePlanillaActionResponseDto
    {
        public Guid Id { get; set; }


        public string Periodo { get; set; }



        public DateTime FechaCreacion { get; set; }



        public DateTime FechaPago { get; set; }

        public string Estado { get; set; }
    }
}
