using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System;
using System.Reflection;
using System.IO;
using BookAPI.Models;

namespace BookAPI
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddDbContext<BookAPIContext>(opt =>
        opt.UseMySql(Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(Configuration["ConnectionStrings:DefaultConnection"])));
      services.AddControllers();

      services.AddSwaggerGen(c =>
      {
        c.SwaggerDoc("v1", new OpenApiInfo { 
          Title = "Api.Solution", 
          Version = "v1",
          Description = "An API containing list of books",
          TermsOfService = new Uri("https://example.com/terms"),
          Contact = new OpenApiContact
          {
              Name = "Chynna Lew & Paige Tiedeman",
              Email = string.Empty,
              Url = new Uri("https://github.com/chynnalew"),
          },
          License = new OpenApiLicense
          {
              Name = "Use under LICX",
              Url = new Uri("https://example.com/license"),
          }
        });
      });
    }
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
        app.UseSwagger();

        app.UseSwaggerUI(c => 
        {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "BookAPI.Solution v1");
        c.RoutePrefix = string.Empty;
        });

      // app.UseHttpsRedirection();

      app.UseRouting();

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}
