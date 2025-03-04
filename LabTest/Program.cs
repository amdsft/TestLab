var builder = WebApplication.CreateBuilder(args);

// Add services for API exploration and Swagger.
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseHttpsRedirection();

// Map the GET endpoint for /entity which returns a SampleEntity.
app.MapGet("/entity", () =>
{
    // Call a separate service method to get the entity.
    var entity = EntityService.GetEntity();
    return Results.Ok(entity);
})
.WithName("GetEntity");

app.Run();

// Expose Program class for integration testing.
public partial class Program { }

// Define the entity.
public record SampleEntity
{
    public int Id { get; init; }
    public string Name { get; init; }
}

// Define a service class to encapsulate the logic.
public static class EntityService
{
    public static SampleEntity GetEntity() =>
        new SampleEntity { Id = 1, Name = "Test Entity" };
}

// Exposing Program cs for Testing
public partial class Program { }
