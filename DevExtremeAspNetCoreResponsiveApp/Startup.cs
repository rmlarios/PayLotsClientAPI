using System.Reflection;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExtremeAspNetCoreResponsiveApp.Model;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;
using Microsoft.AspNetCore.Authorization;
using DevExtremeAspNetCoreResponsiveApp.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http.Extensions;
using DevExtremeAspNetCoreResponsiveApp.Common;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Hosting;
using SimpleInjector;
using NToastNotify;
using Microsoft.AspNetCore.Mvc.Cors;
using DevExpress.AspNetCore;
using DevExpress.AspNetCore.Reporting;
using Microsoft.Extensions.Logging;
using DevExpress.XtraReports.Web.Extensions;
using DevExtremeAspNetCoreResponsiveApp.Services;
using DevExpress.XtraReports.Web.WebDocumentViewer;
using DevExtremeAspNetCoreResponsiveApp.Middlewares;
using DevExtremeAspNetCoreResponsiveApp.Logging;
using DevExtremeAspNetCoreResponsiveApp.Permissions;

namespace DevExtremeAspNetCoreResponsiveApp
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
            //Configurando DevExpress
            services.AddDevExpressControls();
            services.AddScoped<ReportStorageWebExtension, CustomReportStorageWebExtension>();
            services.AddTransient<IWebDocumentViewerReportResolver, CustomWebDocumentViewerReportResolver>();
            services.ConfigureReportingServices(configurator =>
            {
                configurator.ConfigureWebDocumentViewer(viewerConfigurator =>
                {
                    viewerConfigurator.UseCachedReportSourceBuilder();
                    configurator.ConfigureReportDesigner(designerConfigurator =>
                    {
                        designerConfigurator.RegisterDataSourceWizardConfigFileConnectionStringsProvider().EnableCustomSql();
                    });

                });
            });

            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
                options.HttpOnly = Microsoft.AspNetCore.CookiePolicy.HttpOnlyPolicy.None;
            });
            services.AddSingleton<IAuthorizationPolicyProvider, PermissionPolicyProvider>();
            services.AddScoped<IAuthorizationHandler, PermissionAuthorizationHandler>();
            //Conexion a la Base de Datos
            services.AddDbContext<PayLotsDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("PayLotsConnection")));

            //services.AddDbContext<IdentityContext>(options => options.UseSqlServer(Configuration.GetConnectionString("IdentityConnection")));

            //Configuracion de Identity
           services.AddIdentity<AppUser, IdentityRole>(options =>
                    {
                        options.Tokens.AuthenticatorTokenProvider = TokenOptions.DefaultAuthenticatorProvider;
                        options.Password.RequireDigit = true;
                        options.Password.RequiredLength = 8;
                        options.Password.RequireNonAlphanumeric = true;
                        options.Password.RequireUppercase = true;
                        options.Password.RequireLowercase = true;
                        options.User.RequireUniqueEmail = true;
                        options.SignIn.RequireConfirmedEmail = true;
                        options.Lockout.MaxFailedAccessAttempts = 5;                        

                    })
                .AddEntityFrameworkStores<PayLotsDBContext>()                
                .AddDefaultTokenProviders().AddDefaultUI();
           

            //services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
            //.AddRazorPagesOptions(options =>
            //{
            //options.AllowAreas = true;
            //options.Conventions.AuthorizeAreaFolder("Identity", "/Account/Manage");
            //options.Conventions.AuthorizeAreaPage("Identity", "/Account/Logout");
            //});

            //services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();
            services.AddAuthentication(IdentityConstants.ApplicationScheme).AddCookie(
               opt =>
               {
                   opt.LoginPath = $"/Identity/Account/Login";
                   opt.AccessDeniedPath = $"/Identity/Account/Login";
                   opt.Cookie.Name = "identcookie";
                   opt.Cookie.SameSite = SameSiteMode.None;
                 /*  opt.Events = new CookieAuthenticationEvents()
                   {
                       OnRedirectToLogin = redirectContext =>
                       {
                           string redirecturi = redirectContext.RedirectUri;
                           UriHelper.FromAbsolute(
                           redirecturi,
                           out string scheme,
                           out HostString host,
                           out PathString path,
                           out QueryString query,
                           out FragmentString fragment);

                           redirecturi = UriHelper.BuildAbsolute(scheme, host, path);

                           redirectContext.Response.Redirect(redirecturi);

                           return Task.CompletedTask;
                       }
                   };*/
               }
           );

            services.AddAntiforgery(o => o.HeaderName = "XSRF-TOKEN");

            /*  services.ConfigureApplicationCookie(opts =>
             {
                 opts.LoginPath = $"/Identity/Account/Login";
                 opts.AccessDeniedPath = $"/Identity/Account/Login";
                 opts.Cookie.Name = "paylotscookie";
                 opts.Cookie.SameSite = SameSiteMode.None;
                 opts.ExpireTimeSpan = new TimeSpan(hours:4,minutes:0,seconds:0);

                 opts.Events = new CookieAuthenticationEvents()
                 {
                     OnRedirectToLogin = redirectContext =>
                     {
                        string redirecturi = redirectContext.RedirectUri;
                        UriHelper.FromAbsolute(
                        redirecturi,
                        out string scheme,
                        out HostString host,
                        out PathString path,
                        out QueryString query,
                        out FragmentString fragment);

                         redirecturi = UriHelper.BuildAbsolute(scheme, host, path);

                         redirectContext.Response.Redirect(redirecturi);

                         return Task.CompletedTask;
                     }
                 };


             }
             );  */


            //Instancia el UserHelper como Servicio
            services.AddScoped<IUserHelper, UserHelper>();
            //Instancia el servicio para enviar correo
            services.AddScoped<IEmailHelper, MailHelper>();
            //Registro los Proxys
            services.AddTransient<ProxyHttpClient>();
            services.AddTransient<IAuthProxy, AuthProxy>();
            services.AddTransient<IGenericProxy, GenericProxy>();
            services.AddSingleton<ILog, LogNLog>();


            services.AddControllers()
            .AddNewtonsoftJson(o =>
            {
                o.SerializerSettings.ContractResolver = new DefaultContractResolver();
                o.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            });



            //Configuracion de JSON para evitar conflictos con el nombre de los campos
            services.AddMvc()                
            .AddMvcOptions(o =>
            {
                o.EnableEndpointRouting = false;
            })
            /*.AddJsonOptions(options => options.JsonSerializerOptions.ContractResolver = new DefaultContractResolver())
            .AddJsonOptions(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore)*/
            .AddRazorPagesOptions(options =>
            {
                //options.AllowAreas = true;                    
                options.Conventions.AuthorizeFolder("/");
                options.Conventions.AllowAnonymousToPage("/Identity/Account/Login");
               // options.Conventions.AddPageRoute("/Reportes/Viewer", "Viewer/{r}/{p?}");

            }
                )
            ;
            services.AddRazorPages().AddNToastNotifyToastr(new ToastrOptions
            {
                ProgressBar = true,
                PositionClass = ToastPositions.TopRight,
                CloseButton = true,
                TimeOut = 2500,
                CloseDuration = true,
                Type = Enums.NotificationTypesToastr.Success

            })
              .AddRazorPagesOptions(options =>
              {
                  //options.Conventions.AddPageRoute("/Reportes/Viewer", "Viewer/{r}/{p?}");
              }
                );
            //Requiere que el usuario este autenticado para poder acceder a cualquier pagina
            services.AddAuthorization(options =>
            {
                options.DefaultPolicy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
                options.AddPolicy("AdminPolicy", config =>
          {
              config.RequireAuthenticatedUser().Build();
          });
            });

            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));



            services.Configure<CookieTempDataProviderOptions>(options =>
            {
                options.Cookie.IsEssential = true;
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory, ILog logger)
        {
            var reportingLogger = loggerFactory.CreateLogger("DXReporting");
            DevExpress.XtraReports.Web.ClientControls.LoggerService.Initialize((exception, message) =>
            {
                var logMessage = $"[{DateTime.Now}]: Exception occurred. Message: '{message}'. Exception Details:\r\n{exception}";                
                reportingLogger.LogError(logMessage);
            });

            app.UseDevExpressControls();
            System.Net.ServicePointManager.SecurityProtocol |= System.Net.SecurityProtocolType.Tls12;

            app.ConfigureExceptionHandler(logger);
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                //app.UseDeveloperExceptionPage();
                
                
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStatusCodePages();
            app.UseRouting();
            app.UseCors("MyPolicy");
            app.UseStaticFiles();
            app.UseAuthentication();

            app.UseCookiePolicy();
            app.UseNToastNotify();
           // app.UseMiddleware<ErrorHandlingMiddleware>();

            /* app.UseMvc(routes =>
            {
              routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}")
                    ;
            });*/
            app.UseMvc();

            app.UseEndpoints(c => c.MapControllers());

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }


    }
}
