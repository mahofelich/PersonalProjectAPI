using System.ComponentModel.DataAnnotations;

namespace PersonalProjectAPI.Dtos
{
    public record class CreateStandDto(
        [Required][StringLength(50)]string Name, 
        char Power, 
        char Speed,
        char Range, 
        char Persistence,
        char Precision, 
        char Potential, 
        string? Desc,
        byte[]? Img);

}
