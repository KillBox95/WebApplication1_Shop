using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Documenty;
using WebApplication1.Documenty.Interface;
using WebApplication1.Documenty.Mocks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Documenty.Reposotory;


namespace WebApplication1
{
    public class Startup
    {

        private IConfigurationRoot _confstring;

        public Startup(IHostEnvironment hostEnv)
        {
            _confstring = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("Db_setting.json").Build();
        }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confstring.GetConnectionString("DefaultConnection")));
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddTransient<iAllTovars, RepositoryTov>();
            services.AddTransient<iTovarCat, RepositoryCat>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

        }
    }
}
