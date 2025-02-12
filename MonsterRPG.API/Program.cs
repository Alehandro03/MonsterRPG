
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MonsterRPG.API.Configuration.ExceptionResponse;
using MonsterRPG.Data.ConnectDb;
using System.Text.Json.Serialization;

const string? _connString = "MONSTER_CONNECTION_STRING";

var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetValue<string>(_connString);
builder.Services.AddDbContext<ApplicationContext>(op => op.UseSqlServer(connString));

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddMvc()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    })
    .ConfigureApiBehaviorOptions(options =>
    {
        options.InvalidModelStateResponseFactory = context =>
        {
            var exc = new ValidationExceptionResponse(context.ModelState);
            return new UnprocessableEntityObjectResult(exc);
        };
    });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
