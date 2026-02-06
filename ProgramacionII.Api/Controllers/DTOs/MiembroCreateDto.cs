namespace ProgramacionII.Api.Controllers.DTOs
{
    public class MiembroCreateDto
    {
        public string Nombre { get; set; } = null!;
        public string Cedula { get; set; } = null!;
        public string Rol { get; set; } = null!;
    }
}
