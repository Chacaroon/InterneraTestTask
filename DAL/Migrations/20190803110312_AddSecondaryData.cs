using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
	public partial class AddSecondaryData : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AddColumn<string>(
				name: "Name",
				table: "Sellers",
				nullable: true);

			migrationBuilder.AddColumn<string>(
				name: "Name",
				table: "Products",
				nullable: true);

			migrationBuilder.AddColumn<string>(
				name: "Name",
				table: "Customers",
				nullable: true);

			migrationBuilder.AddColumn<string>(
				name: "Name",
				table: "Companies",
				nullable: true);
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropColumn(
				name: "Name",
				table: "Sellers");

			migrationBuilder.DropColumn(
				name: "Name",
				table: "Products");

			migrationBuilder.DropColumn(
				name: "Name",
				table: "Customers");

			migrationBuilder.DropColumn(
				name: "Name",
				table: "Companies");
		}
	}
}
