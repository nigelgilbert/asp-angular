using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using System.IO;
using System;

public class Startup
{
    // Called by the runtime. Use this method to add services to the container.
    // Reference: https://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc();
    }

    // Called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app)
    {
        
        app.UseMvc();
        
    }
};
//         // Serves index.html as the website route.
//         app.UseDefaultFiles();
        
//         // Serve static files in wwwroot.
//         app.UseStaticFiles();
        
//         // Serve static files from node_modules.
//         string dir = Directory.GetCurrentDirectory();
//         app.UseStaticFiles(new StaticFileOptions()
//         {
//             FileProvider = new PhysicalFileProvider(
//                 Path.Combine(dir, "node_modules")
//             ),
//             RequestPath = new PathString("/node_modules")
//         });

//         // Configure the app's routing.
    
//         // app.UseMvc(config => 
//         // {
//         //     config.MapRoute(
//         //         name: "Default",
//         //         template: "{controller}/{action}/{id?}",
//         //         defaults: new { controller = "App", action = "Index" }
//         //     );    
//         // });
//     }
// }