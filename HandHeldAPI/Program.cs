using HandHeldAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DB Context for mySQL
builder.Services.AddDbContext<HandHeldDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("HandHeld"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("HandHeld"))));

// Register IHttpContextAccessor
builder.Services.AddHttpContextAccessor();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
