using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using RentACar.Model.Requests;
using RentACar.WebAPI.Database;
using RentACar.WebAPI.Filters;
using RentACar.WebAPI.Security;
using RentACar.WebAPI.Services;

namespace RentACar.WebAPI
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
            services.AddMvc(x => x.Filters.Add<ErrorFilter>()).AddRazorPagesOptions(options =>
            {
                options.Conventions.AddPageRoute("/Swagger", "");
            });

            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            services.AddControllers();

            //var connection = @"Server =.; Database = RentACar; Trusted_Connection = True;ConnectRetryCount=0";
            var connection = Configuration.GetConnectionString("RentACar");
            services.AddDbContext<RentACarContext>(options => options.UseSqlServer(connection));

            services.AddAutoMapper(typeof(Startup));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });

                c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    In = ParameterLocation.Header,
                    Description = "Basic Authorization header."
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference {
                                Type = ReferenceType.SecurityScheme,
                                Id = "basic" }
                        }, new string[] { } }
                });
            });

            services.AddScoped<ICRUDService<Model.Drzave, object, DrzaveUpsertRequest, DrzaveUpsertRequest>, BaseCRUDService<Model.Drzave, object, Database.Drzave, DrzaveUpsertRequest, DrzaveUpsertRequest>>();
            services.AddScoped<ICRUDService<Model.Gradovi, GradoviSearchRequest, GradoviUpsertRequest, GradoviUpsertRequest>, GradoviService>();
            services.AddScoped<ICRUDService<Model.Lokacije, LokacijeSearchRequest, LokacijeUpsertRequest, LokacijeUpsertRequest>, LokacijeService>();
            services.AddScoped<ICRUDService<Model.Oprema, object, OpremaUpsertRequest, OpremaUpsertRequest>, BaseCRUDService<Model.Oprema, object, Database.Oprema, OpremaUpsertRequest, OpremaUpsertRequest>>();
            services.AddScoped<ICRUDService<Model.Novosti, NovostiSearchRequest, NovostiUpsertRequest, NovostiUpsertRequest>, NovostiServices>();
            services.AddScoped<ICRUDService<Model.Pretplate, PretplateSearchRequest, PretplateUpsertRequest, PretplateUpsertRequest>, PretplateService>();
            services.AddScoped<ICRUDService<Model.Proizvodjaci, object, ProizvodjaciUpsertRequest, ProizvodjaciUpsertRequest>, BaseCRUDService<Model.Proizvodjaci, object, Database.Proizvodjaci, ProizvodjaciUpsertRequest, ProizvodjaciUpsertRequest>>();
            services.AddScoped<ICRUDService<Model.Ocjene, object, OcjeneUpsertRequest, OcjeneUpsertRequest>, BaseCRUDService<Model.Ocjene, object, Database.Ocjene, OcjeneUpsertRequest, OcjeneUpsertRequest>>();
            services.AddScoped<ICRUDService<Model.Modeli, ModeliSearchRequest, ModeliUpsertRequest, ModeliUpsertRequest>,ModeliService>();
            services.AddScoped<IService<Model.Uloge, object>, BaseService<Model.Uloge, object, Database.Uloge>>();
            services.AddScoped<IService<Model.KategorijeVozila, object>, BaseService<Model.KategorijeVozila, object, Database.KategorijeVozila>>();
            services.AddScoped<ICRUDService<Model.Osiguranja, object, OsiguranjaUpsertRequest, OsiguranjaUpsertRequest>, BaseCRUDService<Model.Osiguranja, object, Database.Osiguranja, OsiguranjaUpsertRequest, OsiguranjaUpsertRequest>>();
            services.AddScoped<ICRUDService<Model.RegistracijeVozila, RegistracijeVozilaSearchRequest, RegistracijeVozilaUpsertRequest,RegistracijeVozilaUpsertRequest>, RegistracijeVozilaService>();
            services.AddScoped<ICRUDService<Model.Vozila, VozilaSearchRequest, VozilaUpsertRequest, VozilaUpsertRequest>, VozilaService>();
            services.AddScoped<ICRUDService<Model.Racuni, RacuniSearchRequest, RacuniUpsertRequest, RacuniUpsertRequest>, RacuniService>();
            services.AddScoped<ICRUDService<Model.Rezervacije, RezervacijeSearchRequest, RezervacijeUpsertRequest, RezervacijeUpsertRequest>, RezervacijeService>();
            services.AddScoped<IKorisniciService, KorisniciService>();
            services.AddScoped<IKupciService, KupciService>();
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<ICRUDService<Model.Notifikacije, NotifikacijeSearchRequest, NotifikacijeUpsertRequest, NotifikacijeUpsertRequest>, NotifikacijeService>();
            services.AddScoped<IPreporukeService, PreporukeService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
