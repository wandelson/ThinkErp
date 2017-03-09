using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using Think.Erp.Api.Data.Contexts;

namespace Think.Erp.Api.IntegrationTests.Configuration
{
    //responsavel pelo setup
    //cria o bd e aplica as migrations
    public class BaseTestFixture : IDisposable
    {
        public readonly TestServer Server;
        public readonly HttpClient Client;
        public readonly DataContext TestDbContext;
        public readonly IConfigurationRoot Configuration;

        public BaseTestFixture()
        {
            var envName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{envName}.json", optional: true)
                .AddEnvironmentVariables();

            Configuration = builder.Build();

            var opts = new DbContextOptionsBuilder<DataContext>();
            opts.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            TestDbContext = new DataContext(opts.Options);
            SetupDatabase();

            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        //garantir q o banco ta criado e as migrations estão aplicadas
        private void SetupDatabase()
        {
            try
            {
                TestDbContext.Database.EnsureCreated();
                TestDbContext.Database.Migrate();
            }
            catch (Exception)
            {
                //TODO: Add a better logging
                // Does nothing
            }
        }

        public void Dispose()
        {
            TestDbContext.Dispose();
            Client.Dispose();
            Server.Dispose();
        }
    }
}