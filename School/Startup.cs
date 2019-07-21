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
              .InitLocalization()
               .InitAuthentication(/*Configuration.GetSection(nameof(JwtIssuerOptions)), _signingKey,*/ _apiService)
            .InitMvc();



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
