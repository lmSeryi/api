using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using api.Services;
using api.Services.interfaces;
using api.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using AutoMapper;

namespace api
{
  public class Startup
  {
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }
    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddControllers(action =>
      {
        action.ReturnHttpNotAcceptable = true;
      })
      .AddXmlDataContractSerializerFormatters()
      .AddNewtonsoftJson();

      services.AddTransient<IMailService, LocalMailService>();
      string connectionString = Configuration["connectionStrings:MovieInfoDbConnectionString"];
      services.AddDbContext<MovieInfoContext>(options => options.UseSqlite(connectionString));
      services.AddScoped<IMovieInfoRepository, MovieInfoRepository>();
      services.AddAutoMapper(typeof(Startup));
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseRouting();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}
