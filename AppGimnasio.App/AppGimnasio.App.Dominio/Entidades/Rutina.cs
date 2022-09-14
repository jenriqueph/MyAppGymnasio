using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppGimnasio.App.Dominio
{
    public class Rutina
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo de rutina ejercicio 1 es obligatorio.")]
        [StringLength(300)]
        [Display(Name = "Ejercicio 1")]
        public string? Ejercicio1 { get; set; }
        [StringLength(300)]
        [Display(Name = "Ejercicio 2")]
        public string? Ejercicio2 { get; set; }
        [StringLength(300)]
        [Display(Name = "Ejercicio 3")]
        public string? Ejercicio3 { get; set; }
        [StringLength(300)]
        [Display(Name = "Ejercicio 4")]
        public string? Ejercicio4 { get; set; }
        [StringLength(300)]
        [Display(Name = "Ejercicio 5")]
        public string? Ejercicio5 { get; set; }
        [StringLength(300)]
        [Display(Name = "Cardio")]
        public string? Cardio { get; set; }
        public Boolean Bloqueado { get; set; } = false;
    }
}