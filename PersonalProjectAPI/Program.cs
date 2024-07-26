using Microsoft.EntityFrameworkCore;
using PersonalProjectAPI.Data;
using PersonalProjectAPI.Endpoints;

var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("StandsList");

builder.Services.AddDbContext<StandListContext>(options =>
    options.UseSqlite(connString));

var app = builder.Build();

app.MapStandsEndpoints();

await app.MigrateDbAsync();

app.Run();
