using System;
using System.ComponentModel.DataAnnotations;

namespace AppGimnasio.App.Dominio
{
    public class Rutina
    {
        public int Id { get; set; }
        public string? Ejercicio1 { get; set; }
        public string? Ejercicio2 { get; set; }
        public string? Ejercicio3 { get; set; }
        public string? Ejercicio4 { get; set; }
        public string? Ejercicio5 { get; set; }
        public string? Cardio { get; set; }
        public Boolean Boolean { get; set; } = false;
    }
}