using Microsoft.EntityFrameworkCore;
using PersonalProjectAPI.Data;
using PersonalProjectAPI.Dtos;
using PersonalProjectAPI.Entities;
using PersonalProjectAPI.Mapping;

namespace PersonalProjectAPI.Endpoints
{   public static class StandEndpoints
    {

        const string GetStandEndpointName = "GetStand";

        public static RouteGroupBuilder MapStandsEndpoints(this WebApplication app)
        {


            var group = app.MapGroup("stands");


            //GET stands
            group.MapGet("/", async (StandListContext dbContext) => await dbContext.Stands.Select(stand => stand.ToDto()).AsNoTracking().ToListAsync());



            //GET stands by ID
            group.MapGet("/{ID}", async (int ID, StandListContext dbContext) =>
            {
                Stand? stand = await dbContext.Stands.FindAsync(ID);

                return stand is null ? Results.NotFound() : Results.Ok(stand.ToDto());
            }).WithName(GetStandEndpointName);



            //POST new stand
            group.MapPost("/", async (CreateStandDto newStand,StandListContext dbContext) =>
            {
                if(string.IsNullOrEmpty(newStand.Name))
                {
                    return Results.BadRequest("Name is required");
                }
                Stand stand = newStand.ToEntity();


                dbContext.Stands.Add(stand);
                await dbContext.SaveChangesAsync();

                return Results.CreatedAtRoute(GetStandEndpointName, new { stand.ID }, stand.ToDto());
            });



            //PUT updated stand
            group.MapPut("/{ID}", async (int ID, UpdateStandDto updatedStand, StandListContext dbContext) =>
            {
                var existingStand = await dbContext.Stands.FindAsync(ID);
                if (existingStand is null)
                {
                    return Results.NotFound();
                }
                dbContext.Entry(existingStand).CurrentValues.SetValues(updatedStand.ToEntity(ID));
                
               await dbContext.SaveChangesAsync();

                return Results.NoContent();
            });



            // DELETE stand by ID
            group.MapDelete("/{ID}", async (int ID, StandListContext dbContext) =>
            {   
                //batch delete
               await dbContext.Stands.Where(stand => stand.ID == ID).ExecuteDeleteAsync();

                return Results.NoContent();
            });
            return group;
        }
    }
}
