using Microsoft.EntityFrameworkCore;
using TheKitchenMess.Models;
using TheKitchenMess.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IRecipeManagementService, RecipeManagementService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

var sqlConnectionString = Environment.GetEnvironmentVariable("KitchenMessAPI");

builder.Services.AddDbContext<ModelsContext>(options => options.UseNpgsql(sqlConnectionString));


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//what is this for? (Copied from BookManagerApi)
//app.UseHttpsRedirection()
app.UseAuthorization();

app.MapControllers();

app.Run();