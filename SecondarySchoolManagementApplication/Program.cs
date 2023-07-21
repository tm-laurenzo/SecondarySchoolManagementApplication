using NLog;
using SecondarySchoolManagementApplication.Extensions;
using SSMA.Utilities;

var builder = WebApplication.CreateBuilder(args);
LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));
var config = builder.Configuration;
var environment = builder.Environment;

// Add services to the container.
builder.Services.ConfigureLoggerService();
builder.Services.AddDbContextAndConfigurations(environment, config);
builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(MappingsProfile).Assembly);
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
