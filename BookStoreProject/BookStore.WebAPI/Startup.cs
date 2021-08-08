using Ecommerce.Business.Abstract;
using Ecommerce.Business.Concrete;
using Ecommerce.DataAccess.Abstract;
using Ecommerce.DataAccess.Concrete.Contexts;
using Ecommerce.DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.WebAPI
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
            IServiceCollection serviceCollectionss = services.AddDbContext<ECommerceContext>
                (o => o.UseSqlServer(" Data Source=DESKTOP-QL5AQK8;Initial Catalog=ECommerceDb;Integrated Security=True;Pooling=False",
                 opt => opt.MigrationsAssembly("Ecommerce.DataAccess").MigrationsHistoryTable(HistoryRepository.DefaultTableName, "dbo"))
                );

            services.AddControllers();
            services.AddTransient<IUserDal, EFUserDal>();
            services.AddTransient<IBookDal, EFBookDal>();
            services.AddTransient<IAuthorDal, EFAuthorDal>();
            //services.AddTransient<IOrderDal, EFOrderDal>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IBookService, BookService>();
            services.AddTransient<IAuthorService, AuthorService>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Ecommerce.WebAPI", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Ecommerce.WebAPI v1"));
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
