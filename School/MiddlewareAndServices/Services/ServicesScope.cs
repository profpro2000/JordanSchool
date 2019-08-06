using Core.IAddLookupsRepo;
using Core.IAdmStudRepo;
using Core.IFinancial;
using Core.ILookupRepo;
using Core.IRegRepo;
using Core.UsersRepo;
using Domain;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Persistence.AddLookupsRepo;
using Persistence.AdmRepo;
using Persistence.FinancialRepo;
using Persistence.LookupsRepo;
using Persistence.RegRepo;
using Persistence.UsersRepo;
using School.ServiceLayer.Helper;
using School.ServiceLayer.Services.AddLookupServices;
using School.ServiceLayer.Services.AdmStudServices;
using School.ServiceLayer.Services.FinancialServices;
using School.ServiceLayer.Services.LookupsServices;
using School.ServiceLayer.Services.RegServices;
using School.ServiceLayer.Services.UsersServices;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using School.MiddlewareAndServices.Services;

namespace School.MiddlewareAndServices.Services
{
   
    public static class ServicesScope
    {



        /*
                public static IServiceCollection InitAuthentication(this IServiceCollection services, 
                    IConfigurationSection jwtAppSettingOptions, SymmetricSecurityKey _signingKey,ApiService apiService)
                {
                    services.Configure<JwtIssuerOptions>(options =>
                    {
                        options.Issuer = jwtAppSettingOptions[nameof(JwtIssuerOptions.Issuer)];
                        options.Audience = jwtAppSettingOptions[nameof(JwtIssuerOptions.Audience)];
                        options.SigningCredentials = new SigningCredentials(_signingKey, SecurityAlgorithms.HmacSha256);
                    });

                    //For Authntication 
                    TokenValidationParameters tokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidIssuer = "http://localhost:58488",
                        ValidateAudience = true,
                        ValidAudience = "http://localhost:4200",
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = _signingKey,
                        RequireExpirationTime = false,
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero
                    };

                    services.AddAuthentication(options =>
                    {
                        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

                    }).AddJwtBearer(configureOptions =>
                    {

                         configureOptions.ClaimsIssuer = jwtAppSettingOptions[nameof(JwtIssuerOptions.Issuer)];
                         configureOptions.TokenValidationParameters = tokenValidationParameters;
                         configureOptions.SaveToken = true;
                         configureOptions.SecurityTokenValidators.Clear();
                         configureOptions.SecurityTokenValidators.Add(new TokenValidationHandler(apiService));

                    });

                    // api user claim policy
                    services.AddAuthorization(options =>
                    {
                        options.AddPolicy("ApiUser", policy => policy.RequireClaim("role", "api_access"));
                    });

                    return services;
                }
        */

        public static IServiceCollection InitAuthentication(this IServiceCollection services, IConfigurationSection jwtAppSettingOptions, SymmetricSecurityKey _signingKey, ApiService apiService)
        {
            services.Configure<JwtIssuerOptions>(options =>
            {
                options.Issuer = jwtAppSettingOptions[nameof(JwtIssuerOptions.Issuer)];
                options.Audience = jwtAppSettingOptions[nameof(JwtIssuerOptions.Audience)];
                options.SigningCredentials = new SigningCredentials(_signingKey, SecurityAlgorithms.HmacSha256);
            });


           
        
      
            
            //For Authntication 
            TokenValidationParameters tokenValidationParameters = new TokenValidationParameters
            {
               
            ValidateIssuer = true,
                ValidIssuer = "http://localhost:58488",
                ValidateAudience = true,
                ValidAudience = "http://localhost:4200",
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = _signingKey,
                RequireExpirationTime = false,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero
            };

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(configureOptions =>
            {
                configureOptions.ClaimsIssuer = jwtAppSettingOptions[nameof(JwtIssuerOptions.Issuer)];
                configureOptions.TokenValidationParameters = tokenValidationParameters;
                configureOptions.SaveToken = true;
                configureOptions.RequireHttpsMetadata = false;
                configureOptions.SecurityTokenValidators.Clear();
               // configureOptions.SecurityTokenValidators.Add(new TokenValidationHandler(apiService));
            });

            // api user claim policy
            services.AddAuthorization(options =>
            {
                options.AddPolicy("ApiUser", policy => policy.RequireClaim("role", "api_access"));

            });

            return services;
        }

        public static IServiceCollection InitSignalR(this IServiceCollection services)
        {
            services.AddSignalR();
            return services;
        }

        public static IServiceCollection InitLocalization(this IServiceCollection services)
        {
            services.AddLocalization(o => o.ResourcesPath = "Resources");

            services.Configure<RequestLocalizationOptions>(options =>
            {
                CultureInfo[] supportedCultures = new[]
                {
                    new CultureInfo("en-US"),
                    new CultureInfo("ar")
                };

                options.DefaultRequestCulture = new RequestCulture("en-US");

                // You must explicitly state which cultures your application supports.
                // These are the cultures the app supports for formatting 
                // numbers, dates, etc.
                options.SupportedCultures = supportedCultures;

                // These are the cultures the app supports for UI strings, 
                // i.e. we have localized resources for.
                options.SupportedUICultures = supportedCultures;

                options.RequestCultureProviders = new List<IRequestCultureProvider>
                {
                    new QueryStringRequestCultureProvider(),
                    new CookieRequestCultureProvider(),
                    new AcceptLanguageHeaderRequestCultureProvider()
                };
            });

            return services;
        }

       
        public static IServiceCollection InitMvc(this IServiceCollection services)
        {
            //options =>
            //{
            //    options.Filters.Add(typeof(ControllerNameActionFilter));
            //    // an instance
            //    //options.Filters.Add(typeof(ExceptionGlobalFilter));
            //    //options.Filters.Add(typeof(PermissionFilter));
            //}
            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix,
                    opts => { opts.ResourcesPath = "Resources"; })
                .AddDataAnnotationsLocalization();
            return services;
        }

        public static IServiceCollection InitCors(this IServiceCollection services)
        {
            // CORS
            services.AddCors(options =>
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

            return services;
        }

        public static IServiceCollection AddCache(this IServiceCollection services)
        {
            services.AddMemoryCache();
            return services;
        }


        public static IServiceCollection InitContext(this IServiceCollection services, string connectionString)
        {
            // Context
            services.AddDbContext<SchoolDbContext>(options => options.UseSqlServer(connectionString));
            return services;
        }
        public static IApplicationBuilder InitStartup(this IApplicationBuilder app, bool isDevelopment = false)
        {
            if (isDevelopment)
                app.UseDeveloperExceptionPage();

            app
              .UseDefaultFiles()
              .UseStaticFiles()
             // .UseRequestUserMiddleware()
            //  .UseCultureMiddleware()
             // .UseHttpMachineInfoMiddleware()
              .UseRequestLocalization(app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>().Value)
              .UseCors("AnyOrigin")
              .UseSignalR(opt =>
              {
                //  opt.MapHub<NotificationsHub>("/hub");
              })
              .UseMvc(routes =>
              {
                  routes.MapRoute("api", "api/{controller}/{action=Index}/{id?}");
                  routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
              });

            return app;
        }

        public static IServiceCollection InitCookies(this IServiceCollection services)
        {
            services.ConfigureExternalCookie(config =>
            {
                config.Cookie.Name = "_t";
                config.Cookie.IsEssential = false;
                config.Cookie.HttpOnly = true;
                config.Cookie.SecurePolicy = CookieSecurePolicy.None;
                config.Cookie.SameSite = SameSiteMode.None;
            });

            return services;
        }


        public static IServiceCollection InitDependenciesInjection(this IServiceCollection services)
        {

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
            services.AddScoped<IYearlyStudRegRepo, YearlyStudRegRepo>();
            services.AddScoped<YearlyStudRegService>();
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

            services.AddScoped<IPaymentRepo, PaymentRepo>();
            services.AddScoped<PaymentService>();

            // ==========  Users  ===========
            services.AddScoped<IUserRepo, UserRepo>();
            services.AddScoped<UsersService>();

            // ===Others
            services.AddSingleton<ApiService>();


            return services;

        }
    }
}
