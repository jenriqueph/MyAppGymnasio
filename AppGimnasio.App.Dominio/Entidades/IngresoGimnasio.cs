using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppGimnasio.App.Dominio
{
    public class IngresoGimnasio 
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "La fecha de ingreso es obligatoria.")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Ingreso")]
        public DateTime FechaIngreso { get; set; }
        public Boolean Bloqueado { get; set; } = false;
    }
}