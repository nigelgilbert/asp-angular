using System.IO;
using HelloDotnet;
using HelloDotnet.TwitterStream;
using Microsoft.AspNetCore.Hosting;

public class Program
{
    public static void Main(string[] args)
    {
        var host = new WebHostBuilder()
            .UseKestrel()
            .UseContentRoot(Directory.GetCurrentDirectory())
            .UseIISIntegration()
            .UseStartup<Startup>()
            .Build();

        TwitterStream.PrintHey();
        
        host.Run();
    }
}