using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using VueDemoWithAsp.NetCore.VueCoreConnection;
using Microsoft.EntityFrameworkCore;
using Warehouse_Core.Context;

namespace VueDemoWithAsp.NetCore
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.  
        public void ConfigureServices(IServiceCollection services)
        {
            //Create new database
            services.AddDbContext<WarehouseContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Warehouse_Core")));

            //Create new IN-memory database
            //services.AddDbContext<WarehouseContext>(opt => opt.UseInMemoryDatabase("Warehouse_Core"));

            services.AddControllers();
            // connect vue app - middleware  
            services.AddSpaStaticFiles(options => options.RootPath = "client_app/dist");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.  
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.  
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            // use middleware and launch server for Vue  
            app.UseSpaStaticFiles();
            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "client_app";
                if (env.IsDevelopment())
                {

                    spa.UseVueDevelopmentServer();
                }
            });
        }
    }
}