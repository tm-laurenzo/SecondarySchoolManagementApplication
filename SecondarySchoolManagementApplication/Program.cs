using SecondarySchoolManagementApplication.Extensions;
using static Raven.Client.Constants;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;
var environment = builder.Environment;

// Add services to the container.
builder.Services.AddDbContextAndConfigurations(environment, config);
builder.Services.AddControllers();
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
