
using Context;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();
builder.Services.AddControllers();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddDbContext<PeopleCentralContext>(
				options =>
				{
					options.UseSqlServer("Server=db-peoplecentral.c9pd1fai0fq1.sa-east-1.rds.amazonaws.com,1433;User Id=GuardianRH;Password=MpYXQ9rIarUJKuzXlCBZ;Database=db_people_central;TrustServerCertificate=True;");
					options.EnableSensitiveDataLogging();
				});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
	app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseRouting();
//app.UseAuthorization();
app.UseCors(
					options => options
							.AllowAnyOrigin()
							.AllowAnyMethod()
							.AllowAnyHeader()
			);
app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

//var summaries = new[]
//{
//		"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
//};

//app.MapGet("/weatherforecast", () =>
//{
//	var forecast = Enumerable.Range(1, 5).Select(index =>
//		 new WeatherForecast
//		 (
//				 DateTime.Now.AddDays(index),
//				 Random.Shared.Next(-20, 55),
//				 summaries[Random.Shared.Next(summaries.Length)]
//		 ))
//			.ToArray();
//	return forecast;
//})
//.WithName("GetWeatherForecast");

app.Run();

//internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
//{
//	public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
//}