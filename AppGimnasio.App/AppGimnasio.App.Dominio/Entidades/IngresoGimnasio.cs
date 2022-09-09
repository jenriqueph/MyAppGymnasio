using System;
using System.ComponentModel.DataAnnotations;

namespace AppGimnasio.App.Dominio
{
    public class IngresoGimnasio 
    {
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Ingreso")]
        public DateTime FechaIngreso { get; set; }
        public Boolean Bloqueado { get; set; } = false;
    }
}