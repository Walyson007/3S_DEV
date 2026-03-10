using System.ComponentModel.DataAnnotations;

namespace EventPlus.WebAPI.DTO;

public class TipoEventoDTO
{
    [Required(ErrorMessage = "O campo Título é obrigatório.")]
    public string? Titulo { get; set; }
}
