using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace NetCoreEducation
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            /*
               UYGULAMAYA AIT VERSIION KOTROLUNU DE KONTROL EDEBILIRIZ.
               SetCompatibilityVersion(Compatibility.Version_2_2_1)
               using Micrsoft.AspNetCore.MVC           
            */
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            /* app.UseStaticFiles(); wwwroot KLASORU DISARI ACILIR.
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(),"node_modules")),
                RequestPath = "/modules"
            });
            */

            /*
             UYGULAMAYA GELEN YONLENDIRMELER ICIN VERILECEK ILK CEVAPLARI KURGULAYABILIRIZ.
             DEFAULT ROUTE OLUSTURMAK ICIN app.UseMvcWithDefaultRoute(); KULLANILABILIR.
             {id?} = ? KULLANILDIGINDA OPSIYONEL OLARAK KULLANIM IFADE EDIMILMIS OLUR.
            */

            app.UseMvc(routes =>
            {
                /*
                    DOGRUDAN VARSAYILAN TANIMLAYABILIRIZ. 
                    routes.MapRoute(
                    name: "default",
                    template: "{controller=About}/{action=Profile}");
                 */

                /*
                 BASITCE BLOG PAYLASIMLARI GIBI VS. ICERIK URL DUZENLEMEMIZIDE KENDIMIZ MODELLEYEBILIRIZ.
                 */
                routes.MapRoute(
                    "ByReleased",
                    "course/byreleased/{year}/{month}",
                    new { controller = "Course", action = "ByReleased" },
                    new { year = @"\d{4}", month = @"\d{2}" }
                    );

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Course}/{action=Index}/{id?}");
            });
        }
    }
}