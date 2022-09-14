using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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