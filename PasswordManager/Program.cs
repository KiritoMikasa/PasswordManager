namespace PasswordManager
{
    using System;
    using System.IO;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using PasswordManager.Services;

    class Program
    {

        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            BuildConfig(builder);
            builder.Build();
            
            var host = Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                {
                    services.AddSingleton<PasswordService>();
                })
                .Build();
            
            var service = ActivatorUtilities.CreateInstance<PasswordService>(host.Services);
            service.Run();

            static void BuildConfig(IConfigurationBuilder builder)
            {
                var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

                builder.SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", false, true)
                    .AddJsonFile($"appsettings.{env}.json", true)
                    .AddEnvironmentVariables();
            }
        }
    }
}