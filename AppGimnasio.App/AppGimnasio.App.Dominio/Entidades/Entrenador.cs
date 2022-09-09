using System;
using System.ComponentModel.DataAnnotations;

namespace AppGimnasio.App.Dominio
{
    public class Entrenador : Persona
    {
        [Required, StringLength(30, ErrorMessage="El campo Número de cuenta es obligatorio.")]
        public string NumeroCuenta { get; set; } = null!;
    }
}