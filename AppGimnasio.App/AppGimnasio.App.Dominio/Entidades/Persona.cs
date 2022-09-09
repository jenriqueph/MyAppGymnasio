using System;
using System.ComponentModel.DataAnnotations;

namespace AppGimnasio.App.Dominio
{
    public class Persona
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage="El campo número de identificación es obligatorio.")]
        [Display(Name = "Numero Identificacion")]
        public string NumeroIdentificacion { get; set; } = null!;
        public TipoDocId TipoDocIdentificacion { get; set; }
        [Required]
        [StringLength(100, ErrorMessage="El campo nombres es obligatorio.")]
        [Display(Name = "Nombres")]
        public string Nombres { get; set; } = null!;
        [Required]
        [StringLength(100, ErrorMessage="El campo nombres es obligatorio.")]
        [Display(Name = "Apellidos")]
        public string Apellidos { get; set; } = null!;
        [StringLength(200, ErrorMessage="El campo direccion tiene un liminte de 200 caracteres.")]
        [Display(Name = "Direccion")]
        public string? Direccion { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; } = null!;
        [Required]
        [StringLength(100, ErrorMessage="El campo contraseña es obligatorio.")]
        [Display(Name = "Contraseña")]
        public string Contrasenia { get; set; } = null!;
        public string? Celular { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Nacimiento")]
        public DateTime? FechaNacimiento { get; set; }
        public Sexo Sexo { get; set; }
        public Boolean Bloqueado { get; set; } = false;

    }
}