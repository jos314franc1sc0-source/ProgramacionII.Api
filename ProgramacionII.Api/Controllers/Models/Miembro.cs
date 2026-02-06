using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace ProgramacionII.Api.Controllers.Models
{
    public class Miembro
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Rol { get; set; }
    }
}
public class Miembro
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio")]
    public string Nombre { get; set; }

    [Required(ErrorMessage = "La cédula es obligatoria")]
    public string Cedula { get; set; }

    [Required(ErrorMessage = "El rol es obligatorio")]
    public string Rol { get; set; }
}
