using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

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


builder.Services.AddControllers();

IServiceCollection services = new ServiceCollection();
services.AddControllers();

#region -- Swagger --  
var inf1 = new OpenApiInfo
{
    Title = "API v1.0",
    Version = "v1",
    Description = "Swashbuckle",
    TermsOfService = new Uri("http://appointvn.com"),
    Contact = new OpenApiContact
    {
        Name = "Trang Nguyen",
        Email = "phuongtrang06@gmail.com"
    },
    License = new OpenApiLicense
    {
        Name = "Apache 2.0",
        Url = new Uri("http://www.apache.org/licenses/LICENSE-2.0.html")
    }
};
var inf2 = new OpenApiInfo
{
    Title = "API v2.0",
    Version = "v2",
    Description = "Swashbuckle",
    TermsOfService = new Uri("http://appointvn.com"),
    Contact = new OpenApiContact
    {
        Name = "Trang Nguyen",
        Email = "phuongtrang06@gmail.com"
    },
    License = new OpenApiLicense
    {
        Name = "Apache 2.0",
        Url = new Uri("http://www.apache.org/licenses/LICENSE-2.0.html")
    }
};
services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", inf1);
    c.SwaggerDoc("v2", inf2);
});
#endregion


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
