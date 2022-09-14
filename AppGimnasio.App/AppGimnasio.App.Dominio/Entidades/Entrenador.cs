using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppGimnasio.App.Dominio
{
    public class Entrenador : Persona
    {
        [Required, StringLength(30, ErrorMessage="El campo Número de cuenta es obligatorio.")]
        public string NumeroCuenta { get; set; } = null!;
    }
}