using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ApplicationScreening.Infrastructure.Data;
using ApplicationScreening.Domain.Entities.JobApplicationAggregate;
using ApplicationScreening.Domain.Entities.ApplicationQuestionAggregate;
using ApplicationScreening.Domain.Interfaces;
using ApplicationScreening.Domain.Services;
using AutoMapper;
using ApplicationScreening.Api.Mapping;

namespace ApplicationScreening.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment hostingEnvironment)
        {
            Configuration = configuration;
            Hosting = hostingEnvironment;
        }

        public IConfiguration Configuration { get; }
        public IHostingEnvironment Hosting { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            if (Hosting.IsDevelopment())
            {
                services.AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer("Server=.;Database=application-screening;Trusted_Connection=True;"));
            }
            else
            {
                services.AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));
            }

            services.AddAutoMapper();

            services.AddScoped<IJobApplicationRepository, JobApplicationRepository>();
            services.AddScoped<IApplicationQuestionRepository, ApplicationQuestionRepository>();
            services.AddScoped<IApplicationService, ApplicationService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
