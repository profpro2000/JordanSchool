using AutoMapper;
using Domain;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using School.MiddlewareAndServices.Services;
using School.ServiceLayer.Helper;
using System;
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
             _signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["SecurityKey"]));
          
            _apiService = new ApiService
            {
                IdentityServiceUrl = Configuration["IdentityServiceUrl"]
            };
        }



        // This method gets called by the runtime. Use this method to add services to the container.

        public void ConfigureServices(IServiceCollection services)
        {

            var _securityKey = Configuration["SecurityKey"];
            var _Issuer = Configuration.GetSection("JwtIssuerOptions:Issuer").Value;
            var connection = Configuration.GetConnectionString("Connection");

             services
                .InitDependenciesInjection()
                .InitContext(Configuration.GetConnectionString("Connection"))
                .AddAutoMapper()
                .InitCookies()
                .InitCors()
                .AddCache()
                .InitLocalization()
                // .InitAuthentication(Configuration.GetSection(nameof(JwtIssuerOptions)), _signingKey, _apiService)
                .InitSignalR()
                .InitMvc();
                
            services.AddAuthentication(o =>
             {
                 o.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                 o.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                 o.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;

             }).AddJwtBearer(p =>
             {
                 p.SaveToken = true;
                 p.RequireHttpsMetadata = false;
                 p.TokenValidationParameters = new TokenValidationParameters()
                 {
                     ValidateIssuer = true,
                     ValidateAudience = true,
                     ValidAudience = _Issuer,
                     ValidIssuer = _Issuer,
                     IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_securityKey))

                 };

             });

            services
                .AddDbContext<SchoolDbContext>(options =>
                  options.UseSqlServer(connection))
                 .AddCors(options =>
                 {
                     options.AddPolicy("AnyOrigin",
                         builder =>
                             builder
                                 .AllowAnyMethod()
                                 .AllowAnyHeader()
                                 .AllowAnyOrigin()
                                 .AllowCredentials()
                     );
                 });
            
                //.InitLocalization()
                // .InitAuthentication(/*Configuration.GetSection(nameof(JwtIssuerOptions)),*/ _signingKey, _apiService)
                //.InitMvc()
                // .AddAuthentication(JwtBearerDefaults.AuthenticationScheme);
            services.AddMvc();



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ApiService apiService)
        {
            //app.InitStartup(env.IsDevelopment());


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }



            app.UseCors(builder => builder //--------4: add UseCors
                .AllowAnyOrigin()
                .AllowAnyMethod()
               .AllowAnyHeader()
                .AllowCredentials());
            app.UseHttpsRedirection();
            app.UseAuthentication();
            
            app.UseMvc();
           

            //using (IServiceScope serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            //{
            //    SchoolDbContext context = serviceScope.ServiceProvider.GetRequiredService<SchoolDbContext>();
            //    context.Database.Migrate();
            //    //initializer.Seed();
            //}

           // apiService.IdentityServiceUrl = Configuration["IdentityServiceUrl"];


        }
    }
}
