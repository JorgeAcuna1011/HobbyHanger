using Application.HobbyHanger.Clothing.Queries;
using Microsoft.EntityFrameworkCore;
using Persistence.HobbyHanger;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<HobbyHangerDbContext>(opt =>
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddCors();
builder.Services.AddMediatR(x => 
    x.RegisterServicesFromAssemblyContaining<GetClothingList.Handler>());

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCors(opt => opt.AllowAnyHeader().AllowAnyMethod()
    .WithOrigins("http://localhost:3000", "https://localhost:3000"));

app.MapControllers();

var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;

try
{
    var context = services.GetRequiredService<HobbyHangerDbContext>();
    await context.Database.MigrateAsync();
    await DbInitializer.SeedData(context);
}
catch (Exception ex)
{   
    
    var logger =  services.GetRequiredService<ILogger<Program>>();
    logger.LogError(ex, "An error occurred seeding the DB.");
}

app.Run();
