using AutoMapper;
using Core.IAddLookupsRepo;
using Core.IAdmRepo;
using Core.ILookupRepo;
using Core.IRegRepo;
using Domain;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.AddLookupsRepo;
using Persistence.AdmRepo;
using Persistence.LookupsRepo;
using Persistence.RegRepo;
using School.ServiceLayer.Services.AddLookupServices;
using School.ServiceLayer.Services.AdmServices;
using School.ServiceLayer.Services.LookupsServices;
using School.ServiceLayer.Services.RegServices;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;


namespace School
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

           

            // services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            // services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<SchoolDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("Connection"))); //--------1: add Connection
            services.AddCors(); //--------2: add CORS
            services.AddAutoMapper();
            services.AddMvc(); //--------3: add MVC
                               // services.AddAutoMapper();
                             
          //  services.AddAutoMapper();

            services.AddScoped<ILkpItemCalendarRepo, LkpItemCalendarRepo>();
            services.AddScoped<LkpItemCalendarService>();
            services.AddScoped<ILkpCalendarRepo, LkpCalendarRepo>();
            services.AddScoped<LkpCalendarService>();
            services.AddScoped<ILkpLookupTypeRepo, LkpLookupTypeRepo>();
            services.AddScoped<LkpLookupTypeService>();
            services.AddScoped<ILkpLookupRepo, LkpLookupRepo>();
            services.AddScoped<LkpLookupService>();

            //========Additional Lookups
            services.AddScoped<ILkpSchoolRepo, LkpSchoolRepo>();
            services.AddScoped<LkpSchoolService>();
            services.AddScoped<ILkpSectionRepo, LkpSectionRepo>();
            services.AddScoped<LkpSectionService>();
            services.AddScoped<ILkpTourRepo, LkpTourRepo>();
            services.AddScoped<LkpTourService>();
            services.AddScoped<ILkpBusRepo, LkpBusRepo>();
            services.AddScoped<LkpBusService>();
            services.AddScoped<ILkpClassRepo, LkpClassRepo>();
            services.AddScoped<LkpClassService>();


            services.AddScoped<ILkpDocumentRepo, LkpDocumentRepo>();
            services.AddScoped<LkpDocumentService>();

            //======= Stud Module =============
            services.AddScoped<IRegParentRepo, RegParentRepo>();
            services.AddScoped<RegParentService>();
            services.AddScoped<IRegStudRepo, RegStudRepo>();
            services.AddScoped<RegStudService>();



            //=========================Adm Module==============================//

            services.AddScoped<IAdmStudRepo, AdmStudRepo>();
            services.AddScoped<AdmStudService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseCors(builder => builder //--------4: add UseCors
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials());
            //app.UseHttpsRedirection();
            app.UseMvc();


        }
    }
}
