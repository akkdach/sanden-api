using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;


using sanden_api.Models.DBContext;
using sanden_api.Helpers;
using DinkToPdf.Contracts;
using DinkToPdf;
using System.IO;
using BaselineTypeDiscovery;

namespace sanden_api
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

            ////  allow rigin
            //services.AddCors(o => o.AddPolicy("bypass", builder =>
            //{
            //    builder.AllowAnyOrigin()
            //        .AllowAnyMethod()
            //        .AllowAnyHeader()
            //        .AllowAnyMethod();
            //}));


            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                       builder => builder.AllowAnyOrigin());
                options.AddPolicy("DevPolicy", builder =>
                     builder
                        .AllowAnyHeader()
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                );
            });

            // connection string
            var connection = Configuration.GetConnectionString("sanden");
            var connectionWeb = Configuration.GetConnectionString("BevProConnection");

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Sanden", Version = "beta.v1" });
            });

            services.AddDbContext<SandenDBContext>(options =>
                options.UseSqlServer(connection));
            services.AddHttpContextAccessor();

            services.AddDbContext<WebDBContext>(options =>
             options.UseSqlServer(connectionWeb));



            services.AddHttpContextAccessor();

            services.AddSingleton<IUriService>(o =>
            {
                var accessor = o.GetRequiredService<IHttpContextAccessor>();
                var request = accessor.HttpContext.Request;
                var uri = string.Concat(request.Scheme, "://", request.Host.ToUriComponent());
                return new UriService(uri);
            });


            services.AddHttpClient("bypass", c => { c.DefaultRequestHeaders.Add("Accept", "application/json"); })
            .ConfigurePrimaryHttpMessageHandler(() =>
            {
                HttpClientHandler clientHandler = new HttpClientHandler();
                clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) =>
                {
                    return true;
                };
                return clientHandler;
            });

            var context = new CustomAssemblyLoadContext();
            //context.LoadUnmanagedLibrary(Path.Combine(Directory.GetCurrentDirectory(), "libwkhtmltox.dll"));
            services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));

            services.AddOptions();
            services.AddHttpClient();
            //services.AddAuthentication();
            services.AddHttpContextAccessor();
            services.AddSingleton<IUriService>(o =>
            {
                var accessor = o.GetRequiredService<IHttpContextAccessor>();
                var request = accessor.HttpContext.Request;
                var uri = string.Concat(request.Scheme, "://", request.Host.ToUriComponent());
                return new UriService(uri);
            });

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("DevPolicy");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Sanden API V1");
            });
        }
    }
}
