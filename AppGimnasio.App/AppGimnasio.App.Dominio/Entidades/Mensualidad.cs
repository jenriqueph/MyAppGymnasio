using System;
using System.ComponentModel.DataAnnotations;

namespace AppGimnasio.App.Dominio
{
    public class Mensualidad
    {
        public int Id { get; set; }
        [Required, Range(0,99999999)]
        public double ValorMensualidad { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        [Required, Display(Name = "Fecha Inicio")]
        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }
        [Required, Display(Name = "Fecha Fin")]
        [DataType(DataType.Date)]
        public DateTime FechaFin { get; set; }
        public Boolean Bloqueado  { get; set; } = false;
    }
}