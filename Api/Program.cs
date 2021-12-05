using Microsoft.OpenApi.Models;
using Octokit.Services;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IGithubAPIService, GithubAPIService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "TakeBlipRepositories API",
        Description = "An ASP.NET Core Web API for querying TakeBlip repositories",
        Contact = new OpenApiContact
        {
            Name = "Contact",
            Url = new Uri("https://github.com/MateusFerreiraSilva"),
            Email = "mateus.ferreiraa.silvaa@gmail.com"
        }
    });

    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
}
);

app.UseAuthorization();

app.MapControllers();

app.Run();
