using Microsoft.Extensions.Logging;

namespace CondoQuestionnaire.Migration;

public class MigrationApplicationSettings
{
    public LoggingSettings Logging { get; set; }
    public DatabaseConnections DatabaseConnections { get; set; }
}

public class LoggingSettings
{
    public LogLevelSetting LogLevel { get; set; }
}

public class LogLevelSetting
{
    public LogLevel Default { get; set; }
    public LogLevel System { get; set; }
    public LogLevel Microsoft { get; set; }
}

public class DatabaseConnections
{
    public PostgresConnection Postgres { get; set; }
}

public class PostgresConnection
{
    public string DbHost { get; set; }
    public string DbPort { get; set; }
    public string DbUser { get; set; }
    public string DbPassword { get; set; }
    public string DbName { get; set; }
    public string DbSchema { get; set; } = "public";
    public string SslMode { get; set; } = "prefer";

    public override string ToString()
    {
        return $"postgresql://{DbUser}:{DbPassword}@{DbHost}:{DbPort}/{DbName}?sslmode={SslMode}";
    }
}

