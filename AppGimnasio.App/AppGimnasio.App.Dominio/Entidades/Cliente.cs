using System;
using System.ComponentModel.DataAnnotations;

namespace AppGimnasio.App.Dominio
{
    public class Cliente : Persona
    {
        public string? Peso { get; set; }
        public IngresoGimnasio? Ingresos { get; set; }
        public Mensualidad? Mensualidad { get; set; }
        public Rutina? Rutina { get; set; }
    }
}