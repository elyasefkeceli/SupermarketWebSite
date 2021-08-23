using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Supermarket.Business.Abstract;
using Supermarket.Business.Concrete;
using Supermarket.DataAccess.Abstract;
using Supermarket.DataAccess.Concrete.EntityFramework;
using Supermarket.Web.Entities;
using Supermarket.Web.Middlewares;
using Supermarket.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Supermarket.Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal, EfProductDal>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddSingleton<ICartSessionService, CartSessionService>();
            services.AddSingleton<ICartService, CartService>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddDbContext<CustomIdentityDbContext>(options => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SupermarketWebDb;Trusted_Connection=true"));
            services.AddIdentity<CustomIdentityUser, CustomIdentityRole>().AddEntityFrameworkStores<CustomIdentityDbContext>().AddDefaultTokenProviders();
            services.AddMvc();
            services.AddSession();
           
            services.AddDistributedMemoryCache();
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseFileServer();
            app.UseNodeModules(env.ContentRootPath);
            app.UseSession();
            app.UseRouting();
            app.UseAuthentication();
            


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "default", pattern: "{Controller=Product}/{Action=Index}/{id?}");
            });
        }
    }
}
