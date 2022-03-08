using text.analyzer.services;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddScoped<IWordRepository, WordRepository>()
    .AddControllers();

services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();
app.Run();
