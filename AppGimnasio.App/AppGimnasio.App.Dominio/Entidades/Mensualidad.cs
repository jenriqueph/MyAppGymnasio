namespace AppGimnasio.App.Dominio
{
    public class Mensualidad
    {
        public int Id { get; set; }
        public double ValorMensualidad { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public Boolean Bloqueado  { get; set; }
    }
}