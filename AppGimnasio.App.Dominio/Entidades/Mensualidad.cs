using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppGimnasio.App.Dominio
{
    public class Mensualidad
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo valor de la mensualidad es obligatorio.")]
        [Range(0,99999999)]
        [Display(Name = "Valor de Mensualidad")]
        public double ValorMensualidad { get; set; }
        [Required(ErrorMessage = "La fecha de registro es obligatoria.")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de ingreso")]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "La fecha de inicio es obligatoria.")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Inicio")]
        public DateTime FechaInicio { get; set; }
        [Required(ErrorMessage = "La fecha final es obligatoria.")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Final")]
        public DateTime FechaFin { get; set; }
        public Boolean Bloqueado  { get; set; } = false;
    }
}