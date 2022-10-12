using CondoQuestionnaire.Migration.Migrations;
using FluentMigrator.Runner;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CondoQuestionnaire.Migration;

public class StartUp
{
    private IHostEnvironment _environment;

    public StartUp(IHostEnvironment environment)
    {
        _environment = environment;
    }
    
    private IConfiguration BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(_environment.ContentRootPath)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddJsonFile($"appsettings.{_environment.EnvironmentName}.json", optional: true)
            .AddEnvironmentVariables();
        
        return builder.Build();
    }

    /// <summary>
    /// Configure the dependency injection services
    /// </summary>
    public IServiceProvider CreateServices()
    {
        var configuration = BuildConfiguration();
        var services = new ServiceCollection();
        var applicationSettings =
            configuration.GetValue<MigrationApplicationSettings>(nameof(MigrationApplicationSettings));
        
        return new ServiceCollection()
            .AddFluentMigratorCore()
            .ConfigureRunner(rb => rb
                .AddPostgres()
                .WithGlobalConnectionString(applicationSettings.DatabaseConnections.Postgres.ToString())
                .ScanIn(typeof(InitalMigration).Assembly).For.Migrations())
            .AddLogging(lb => lb.AddFluentMigratorConsole())
            .BuildServiceProvider(false);
    }
}