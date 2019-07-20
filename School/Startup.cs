using AutoMapper;
using Core.IAddLookupsRepo;
using Core.IAdmStudRepo;
using Core.IFinancial;
using Core.ILookupRepo;
using Core.IRegRepo;
using Core.UsersRepo;
using Domain;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Persistence.AddLookupsRepo;
using Persistence.AdmRepo;
using Persistence.FinancialRepo;
using Persistence.LookupsRepo;
using Persistence.RegRepo;
using Persistence.UsersRepo;
using School.MiddlewareAndServices.Services;
using School.ServiceLayer.Services.AddLookupServices;
using School.ServiceLayer.Services.AdmStudServices;
using School.ServiceLayer.Services.FinancialServices;
using School.ServiceLayer.Services.LookupsServices;
using School.ServiceLayer.Services.RegServices;
using School.ServiceLayer.Services.UsersServices;
using System.Text;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;


namespace School
{
    public class Startup
    {

        public IConfiguration Configuration { get; }
        private readonly SymmetricSecurityKey _signingKey;
        private readonly ApiService _apiService;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
           // _signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["SecurityKey"]));
            _apiService = new ApiService
            {
                IdentityServiceUrl = Configuration["SecurityKey"]
            };
        }

     

        // This method gets called by the runtime. Use this method to add services to the container.
       
        public void ConfigureServices(IServiceCollection services)
        {


            services
               .InitDependenciesInjection()
               .InitContext(Configuration.GetConnectionString("Connection"))
               .AddAutoMapper()
            .InitCors()
            //   .InitCookies()
              .InitLocalization()
               .InitAuthentication(/*Configuration.GetSection(nameof(JwtIssuerOptions)), _signingKey,*/ _apiService)
            //  .InitSignalR()
            .InitMvc();

/*
            // services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            // services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<SchoolDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("Connection"))); //--------1: add Connection
            services.AddCors(); //--------2: add CORS
            services.AddAutoMapper();
            services.AddMvc(); //--------3: add MVC
                               // services.AddAutoMapper();

            */
        
            /*
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
            services.AddScoped<ILkpYearRepo, LkpYearRepo>();
            services.AddScoped<LkpYearService>();

            //======= Stud Module =============
            services.AddScoped<IRegParentRepo, RegParentRepo>();
            services.AddScoped<RegParentService>();
            services.AddScoped<IRegStudRepo, RegStudRepo>();
            services.AddScoped<RegStudService>();
            //===========Users Scope
            services.AddScoped<UserService>();
            //=======Admisiion Module
            services.AddScoped<IAdmStudRepo, AdmStudRepo>();
            services.AddScoped<AdmStudService>();


            //===================Financial
            services.AddScoped<IFinItemRepo, FinItemRepo>();
            services.AddScoped<FinItemService>();

            services.AddScoped<ISchoolFeeRepo, SchoolFeeRepo>();
            services.AddScoped<SchoolFeeService>();

            services.AddScoped<IClassFeeRepo, ClassFeeRepo>();
            services.AddScoped<ClassFeeService>();

            services.AddScoped<IStudentFeeRepo, StudentFeeRepo>();
            services.AddScoped<StudentFeeService>();

            // ==========  Users  ===========
            services.AddScoped<IUserRepo, UserRepo>();
            services.AddScoped<UsersService>();
            */



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
