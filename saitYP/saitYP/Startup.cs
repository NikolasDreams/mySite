using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using saitYP.Data.interfaces;
using saitYP.Data.mocks;
//настройки 
namespace saitYP
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)//регистрация модулей и плагинов
        {
            services.AddTransient<IAllCars, MockCars>();
            services.AddTransient<IAllCars, MockCars>();
            services.AddTransient<ICarsCategory, MockCategory>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
                app.UseDeveloperExceptionPage();//страничка с ошибками
                app.UseDeveloperExceptionPage();//коды ошибок
                app.UseStaticFiles();
                app.UseMvcWithDefaultRoute();//вызывает контроллер по умл
        }
    }
}
