using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BondingGapAPI.Application.Implementation;
using BondingGapAPI.Application.Interfaces;
using BondingGapAPI.Data.EF.Repository;
using BondingGapAPI.Data.EF.Repository.DataRepository;
using BondingGapAPI.Data.EF.Repository.MesRepository;
using BondingGapAPI.Data.IRepository;
using BondingGapAPI.Data.IRepository.IRepositoryData;
using BondingGapAPI.Data.IRepository.IRepositoryMes;
using BondingGapCore.Data.EF;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Serialization;
using PlanningCore3.Application.AutoMapper;

namespace BondingGapCoreAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        [Obsolete]
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<AppDbMesContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("CBMesConnection")).ConfigureWarnings(warnings => warnings.Ignore(CoreEventId.IncludeIgnoredWarning));
            });
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("CBConnection")).ConfigureWarnings(warnings => warnings.Ignore(CoreEventId.IncludeIgnoredWarning));
            });

            services.AddCors(o => o.AddPolicy("CorsPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod().Build();
            }));

            //Mapper
            services.AddAutoMapper(typeof(Startup));
            services.AddScoped<IMapper>(sp =>
            {
                return new Mapper(AutoMapperConfig.RegisterMappings());
            });
            services.AddSingleton(AutoMapperConfig.RegisterMappings());


            //Repository
            services.AddTransient<IMesDeptRepository, MesDeptRepository>();
            services.AddTransient<IMesLineRepository, MesLineRepository>();
            services.AddTransient<IMesMoRepository, MesMoRepository>();
            services.AddTransient<IMesOrgRepository, MesOrgRepository>();
            services.AddTransient<ISettingArticleDateTimeRangeRepository, SettingArticleDateTimeRangeRepository>();
            services.AddTransient<ISettingHourlyLabelRepository, SettingHourlyLabelRepository>();
            services.AddTransient<IRecordRepository, RecordRepository>();
            services.AddTransient<IRecordDetailRepository, RecordDetailReopository>();


            //Service
            services.AddTransient<IMesService, MesService>();
            services.AddTransient<ISettingHourlyLabelService, SettingHourlyLabelService>();
            services.AddTransient<IRecordService, RecordService>();
            services.AddTransient<IRecordDetailService, RecordDetailService>();

            services.AddControllers().AddNewtonsoftJson(options =>
            {
                // Use the default property (Pascal) casing
                options.SerializerSettings.ContractResolver = new DefaultContractResolver();
            });
            services.AddMvc();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Bonding gap API", Version = "v1" });
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
                app.UseHsts();
            }
            app.UseCors("CorsPolicy");

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseSwagger();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseStaticFiles();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "spa-fallback",
                    pattern: "{controller=FallBack}/{action=Index}/{id?}"
                );

                endpoints.MapFallbackToController("Index", "FallBack");
            });

            // Register the Swagger generator, defining 1 or more Swagger documents

        }
    }
}
