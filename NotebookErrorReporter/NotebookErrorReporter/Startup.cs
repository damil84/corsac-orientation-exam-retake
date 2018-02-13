using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using NotebookErrorReporter.Entities;
using NotebookErrorReporter.Repositories;
using NotebookErrorReporter.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace NotebookErrorReporter
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddScoped<Context>();
            services.AddScoped<Repository>();
            services.AddScoped<NamesTicketsVM>();
            services.AddDbContext<Context>(options => options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ErrorReporterDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            app.UseStaticFiles();
            
        }
    }
}