using FluentMigrator;

namespace Footsal.Migrations;
[Migration(202402171938)]
public class _202402171938_AddPlayer : Migration
{
    public override void Up()
    {
        Create.Table("Players")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity().NotNullable()
            .WithColumn("FirstName").AsString().NotNullable()
            .WithColumn("LastName").AsString().NotNullable()
            .WithColumn("BirthDate").AsDateTime().NotNullable();
    }

    public override void Down()
    {
        Delete.Table("Players");
    }
}