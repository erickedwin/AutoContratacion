using Microsoft.EntityFrameworkCore;
using AutoContratacion.Context;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var AzureWinYacu = builder.Configuration.GetConnectionString("AzureWin");
var crm = builder.Configuration.GetConnectionString("CRM");
//AZURE WIN YACURUNA
builder.Services.AddDbContext<LeadContext>(
    options => options.UseSqlServer(AzureWinYacu)
); 

//CRM WIN TABLA REPLICA
builder.Services.AddDbContext<crmwinContext>(
    options => options.UseSqlServer(crm)
); 
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
    app.UseSwagger();
    app.UseSwaggerUI();
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
