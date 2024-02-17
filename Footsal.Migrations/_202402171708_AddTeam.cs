using Microsoft.EntityFrameworkCore.Migrations;
using Migration = FluentMigrator.Migration;

namespace Footsal.Migrations;
[FluentMigrator.Migration(202402171708)]
public class _202402171708_AddTeam : Migration
{
    public override void Up()
    {
        Create.Table("Teams")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity().NotNullable()
            .WithColumn("Name").AsString(50).NotNullable()
            .WithColumn("PlayerCount").AsInt32().NotNullable()
            .WithColumn("MainColor").AsInt32().NotNullable()
            .WithColumn("MinorColor").AsInt32().NotNullable();
    }

    public override void Down()
    {
        Delete.Table("Teams");
    }
}