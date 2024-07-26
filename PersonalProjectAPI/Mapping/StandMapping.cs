using PersonalProjectAPI.Entities;
using PersonalProjectAPI.Dtos;
namespace PersonalProjectAPI.Mapping
{
    public static class StandMapping
    {
        public static Stand ToEntity(this CreateStandDto stand)
        {
            return new Stand()
            {
                Name = stand.Name,
                Power = stand.Power,
                Speed = stand.Speed,
                Range = stand.Range,
                Persistence = stand.Persistence,
                Precision = stand.Precision,
                Potential = stand.Potential,
                Img = stand.Img

            };
        }
        public static StandDto ToDto(this Stand stand)
        {
            return new(
                stand.ID,
                stand.Name,
                stand.Power,
                stand.Speed,
                stand.Range,
                stand.Persistence,
                stand.Precision,
                stand.Potential,
                string.Empty,
                stand.Img);
        }

        public static Stand ToEntity(this UpdateStandDto stand, int ID)
        {
            return new Stand()
            {
                ID = ID,
                Name = stand.Name,
                Power = stand.Power,
                Speed = stand.Speed,
                Range = stand.Range,
                Persistence = stand.Persistence,
                Precision = stand.Precision,
                Potential = stand.Potential,
                Img=stand.Img

            };
        }
    }
}
