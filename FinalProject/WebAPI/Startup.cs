using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
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
            services.AddControllers().AddNewtonsoftJson(o =>
            {
                o.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });
            services.AddDbContext<KolayIkContext>(options => options.UseSqlServer(Configuration.GetConnectionString("KolayIkConnectionString")));
            services.AddScoped<ICalisanDal, EfCalisanDal>();
            services.AddScoped<ICalisanHarcamaDal, EfCalisanHarcamaDal>();
            services.AddScoped<ICalisanAvansDal, EfCalisanAvansDal>();
            services.AddScoped<IIzinDal, EfIzinDal>();
            services.AddScoped<IBildirimDal, EfBildirimDal>();
            services.AddScoped<ISifreDal, EfSifreDal>();
            services.AddScoped<IUyelikPlaniDal, EfUyelikPlaniDal>();
            services.AddScoped<IKullaniciYorumuDal, EfKullaniciYorumuDal>();
            services.AddScoped<IEgitimBilgiDal, EfEgitimBilgiDal>();
            services.AddScoped<ISirketDal, EfSirketDal>();
            services.AddScoped<ISirketUyelikPlaniDal, EfSirketUyelikPlaniDal>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }



            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
