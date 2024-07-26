using Microsoft.EntityFrameworkCore;
using PersonalProjectAPI.Entities;


namespace PersonalProjectAPI.Data
{
    public class StandListContext(DbContextOptions<StandListContext> options) : DbContext(options)
    {
        public DbSet<Stand> Stands => Set<Stand>();

    }
}
