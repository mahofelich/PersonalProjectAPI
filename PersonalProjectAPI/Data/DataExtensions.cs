using Microsoft.EntityFrameworkCore;

namespace PersonalProjectAPI.Data
{
    public static class DataExtensions
    {
        public static async Task MigrateDbAsync(this WebApplication app)
        {
            using var scope=app.Services.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<StandListContext>();
            await dbContext.Database.MigrateAsync();
        }
    }
}
