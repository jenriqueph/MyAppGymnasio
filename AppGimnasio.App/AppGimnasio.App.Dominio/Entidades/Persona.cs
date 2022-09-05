namespace AppGimnasio.App.Dominio
{
    public class Persona
    {
        public int Id { get; set; }
        public string NumeroIdentificacion { get; set; }
        public TipoDocId TipoDocIdentificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Sexo Sexo { get; set; }
        public Boolean Bloqueado { get; set; }

    }
}