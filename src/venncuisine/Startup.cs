using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions;
using venncuisine.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using Newtonsoft.Json.Serialization;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace venncuisine
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()
                .AddJsonOptions(options =>
                {
                    options.SerializerSettings.ContractResolver =
                        new CamelCasePropertyNamesContractResolver();
                });
            services.AddEntityFrameworkSqlServer()
                .AddDbContext<VennCuisineContext>(options =>
                {
                    options.UseSqlServer(Configuration["Data:Server=tcp:venncuisine.database.windows.net,1433;Initial Catalog=venncuisine;Persist Security Info=False;User ID=michaelpassaglia;Password=Poop3rtin0!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"]);
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
            });
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }

        public IConfigurationRoot Configuration { get; set; }
        public Startup()
        {
            var builder = new ConfigurationBuilder()
                //.AddJsonFile("config.json")
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

    }
}
