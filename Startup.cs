using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using System.IO;

public class Startup
{
    // Called by the runtime. Use this method to add services to the container.
    // Reference: https://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {
    }

    // Called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app)
    {
        string dir = Directory.GetCurrentDirectory();
        
        // Serve static files in wwwroot.
        app.UseDefaultFiles();
        
        // Serve static files from node_modules.
        app.UseStaticFiles();
        app.UseStaticFiles(new StaticFileOptions()
        {
            FileProvider = new PhysicalFileProvider(
                Path.Combine(dir, "node_modules")
            ),
            RequestPath = new PathString("/node_modules")
        });
    }
}