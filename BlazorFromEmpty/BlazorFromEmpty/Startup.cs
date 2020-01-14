using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BlazorFromEmpty
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            #region �b�o�̭n�ŧi�ҭn�ϥΪ��A��
            services.AddRazorPages();
            services.AddServerSideBlazor();
            // �]�۱N�o����Ѱ_�ӡA�åB����A�ݬݷ|�o�ͬƻ���D�H
            //services.Configure<RazorPagesOptions>(options => options.RootDirectory = "/");
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            #region �Х[�J�o���ԭz
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            #endregion

            app.UseEndpoints(endpoints =>
            {
                #region �N����ťձM�פ����ԭz�A���Ѱ_��
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});
                #endregion

                #region �Цb�o�̥[�J Blazor �|�Ψ쪺���ѳ]�w�\��
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
                #endregion
            });
        }
    }
}
