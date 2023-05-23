global using SimpleEmailApp.Services.EmailService;
global using SimpleEmailApp.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IEmailService, EmailService>();

var app = builder.Build();

Console.WriteLine("Please enter your username:");
var username = Console.ReadLine();

Console.WriteLine("Please enter your password:");
var password = Console.ReadLine();

Console.WriteLine("Please enter your password:");
var recipient = Console.ReadLine();

Console.WriteLine("Please enter the subject of your email:");
var subject = Console.ReadLine();

Console.WriteLine("Please enter the body of your email:");
var body = Console.ReadLine();

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