using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mailSender.Interface;
using mailSender.Services;

namespace mailSender
{
    public class StartUp
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Register services using IServiceCollection methods
            services.AddTransient<IMail, Mail>(); // Example registration
            services.AddControllers();
        }
        public void Configure(IApplicationBuilder app)
        {
            
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}