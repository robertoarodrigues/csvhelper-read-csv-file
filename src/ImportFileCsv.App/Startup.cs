using FluentValidation.AspNetCore;
using ImportFileCsv.App.Infrastructure.Services.CsvHelper;
using ImportFileCsv.App.Models.FluentValidator;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ImportFileCsv.App
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ICsvHelperService, CsvHelperService>();
            services.AddRazorPages();
            services.AddMvc().AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<BeneficiarioValidator>());

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    "default",
                    "{controller=ImportFile}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
