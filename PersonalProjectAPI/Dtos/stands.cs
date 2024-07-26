namespace PersonalProjectAPI.Dtos
{
    public record class StandDto(int ID, string Name,char Power,char Speed,
        char Range, char Persistence, char Precision, char Potential,string? Desc, byte[]? Img)
    {
    }
}
