using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using JuanFe.Supermarket.Product.Interface.Solution;
using JuanFe.Supermarket.Product.Solution.Infrastructure.BusinessLogic;
using Microsoft.Extensions.Configuration;
using Swashbuckle.Examples;
using JuanFe.Supermarket.Product.Solution.Infrastructure.Helpers;

namespace JuanFe.Supermarket.Product.Solution
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            ServiceBusHelper.Initialize(Configuration);
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Dependency injection
            services.AddScoped<IProductBussinesLogic, ProductBussinesLogic>();
            services.AddControllers();
            AddSwagger(services);
            
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Product API V1");
                });
            }
            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }

        private void AddSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                var groupName = "v1";

                options.SwaggerDoc(groupName, new OpenApiInfo
                {
                    Title = $"Products {groupName}",
                    Version = groupName,
                    Description = "Swagger Documentation API for the SuperMarket Products",
                });
            });
        }
    }
}
