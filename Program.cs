using CommanderGraphQL.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Get Configuration
var configuration = builder.Configuration;

// Add DbContext
builder.Services.AddCommanderDBContext(configuration);

// Add Dependencies
builder.Services.AddProviders();


var app = builder.Build();


app.UseAuthorization();
app.MapControllers();


app.Run();