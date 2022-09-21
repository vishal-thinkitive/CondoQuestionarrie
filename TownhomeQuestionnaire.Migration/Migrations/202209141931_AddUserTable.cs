using FluentMigrator;
using TownhomeQuestionnaire.Core.Models;

namespace TownhomeQuestionnaire.Migration.Migrations;

[Migration(version: 202209141931, description: "Used for identifying and authenticating users")]
public class AddUserTable : FluentMigrator.Migration {
    public override void Up()
            {
                Create.Table(nameof(User))
                    .WithColumn(nameof(User.Id)).AsGuid().PrimaryKey().Identity()
                    .WithColumn(nameof(User.Name)).AsString()
                    .WithColumn(nameof(User.Email)).AsString()
                    .WithColumn(nameof(User.Phone)).AsString()
                    .WithColumn(nameof(User.Salt)).AsString()
                    .WithColumn(nameof(User.Password)).AsString()
                    .WithColumn(nameof(User.CreatedAtUtc)).AsDateTime()
                    .WithColumn(nameof(User.UpdatedAtUtc)).AsDateTime()
                    .WithColumn(nameof(User.DeletedAtUtc)).AsDateTime().Nullable();
            }
    
            public override void Down()
            {
                Delete.Table(nameof(User));
            }
}