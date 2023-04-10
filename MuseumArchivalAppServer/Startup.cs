using DataAccess.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MuseumArchivalAppServer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Repository.IRepository;
using Business.Repository;
using Telerik.Reporting.Services;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Telerik.Reporting.Cache.File;
using Radzen;
using MuseumArchivalAppServer.Areas.StoredModel;

namespace MuseumArchivalAppServer
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddNewtonsoftJson();
            //services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(p =>
                {
                    p.AllowAnyOrigin();
                    p.AllowAnyMethod();
                    p.AllowAnyHeader();
                });
            });
            
            services.AddScoped<IArchivalItemRepository, ArchivalItemRepository>();
            services.AddScoped<IProvidenceRepository, ProvidenceRepository>();
            services.AddScoped<IKeywordTagRepository, KeywordTagRepository>();
            services.AddScoped<IKeywordTagGroupRepository, KeywordTagGroupRepository>();
            services.AddSingleton<StoredItems>();
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<DialogService>();
            services.AddScoped<NotificationService>();
            services.AddScoped<TooltipService>();
            services.AddScoped<ContextMenuService>();
            services.AddSingleton<WeatherForecastService>();
            services.Configure<IISServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });
            services.TryAddSingleton<IReportServiceConfiguration>(sp => new ReportServiceConfiguration
            {
                ReportingEngineConfiguration = Configuration,
                HostAppId = "Net5RestServicewithCors",
                Storage = new FileStorage(),
                ReportSourceResolver = new UriReportSourceResolver(
                    System.IO.Path.Combine(
                        sp.GetService<IWebHostEnvironment>().WebRootPath,
                        "Reports"))
            }) ;
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlite("Data Source = Archive.db");
            });
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseCors();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapControllers();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
