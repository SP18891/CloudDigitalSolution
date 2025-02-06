using CDS.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;

namespace CloudDigitalSolution
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        [System.STAThreadAttribute()]
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.10.0")]
        public static void Main()
        {
            using IHost host = Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((context, config) =>
                {
                    config.AddJsonFile("appsettings.json");
                    config.AddConfiguration(config.Build());
                })
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<CDSContext>(Options =>
                    {
                        var connectionstring = context.Configuration.GetSection("Database:ConnectionString").Value;
                        Options.UseMySQL(connectionstring!);
                    });
                })
                .Build();
            host.Start();

            CloudDigitalSolution.App app = new CloudDigitalSolution.App();
            app.InitializeComponent();
            //using (var scope = host.Services.CreateScope())
            //{
            //    using (var dbContext = scope.ServiceProvider.GetRequiredService<CDSContext>())
            //    {
            //        dbContext.Database.EnsureCreated();
            //    }
            //}

            app.Run();
        }
    }
}