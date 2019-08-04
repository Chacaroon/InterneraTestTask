using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
	public partial class AddDataSeedingForSecondaryData : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.UpdateData(
				table: "Companies",
				keyColumn: "Id",
				keyValue: 1L,
				column: "Name",
				value: "Company 1");

			migrationBuilder.UpdateData(
				table: "Companies",
				keyColumn: "Id",
				keyValue: 2L,
				column: "Name",
				value: "Company 2");

			migrationBuilder.UpdateData(
				table: "Companies",
				keyColumn: "Id",
				keyValue: 3L,
				column: "Name",
				value: "Company 3");

			migrationBuilder.UpdateData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 1L,
				column: "Name",
				value: "Customer 1");

			migrationBuilder.UpdateData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 2L,
				column: "Name",
				value: "Customer 2");

			migrationBuilder.UpdateData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 3L,
				column: "Name",
				value: "Customer 3");

			migrationBuilder.UpdateData(
				table: "Products",
				keyColumn: "Id",
				keyValue: 1L,
				column: "Name",
				value: "Product 1");

			migrationBuilder.UpdateData(
				table: "Products",
				keyColumn: "Id",
				keyValue: 2L,
				column: "Name",
				value: "Product 2");

			migrationBuilder.UpdateData(
				table: "Products",
				keyColumn: "Id",
				keyValue: 3L,
				column: "Name",
				value: "Product 3");

			migrationBuilder.UpdateData(
				table: "Sellers",
				keyColumn: "Id",
				keyValue: 1L,
				column: "Name",
				value: "Seller 1");

			migrationBuilder.UpdateData(
				table: "Sellers",
				keyColumn: "Id",
				keyValue: 2L,
				column: "Name",
				value: "Seller 2");

			migrationBuilder.UpdateData(
				table: "Sellers",
				keyColumn: "Id",
				keyValue: 3L,
				column: "Name",
				value: "Seller 3");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.UpdateData(
				table: "Companies",
				keyColumn: "Id",
				keyValue: 1L,
				column: "Name",
				value: null);

			migrationBuilder.UpdateData(
				table: "Companies",
				keyColumn: "Id",
				keyValue: 2L,
				column: "Name",
				value: null);

			migrationBuilder.UpdateData(
				table: "Companies",
				keyColumn: "Id",
				keyValue: 3L,
				column: "Name",
				value: null);

			migrationBuilder.UpdateData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 1L,
				column: "Name",
				value: null);

			migrationBuilder.UpdateData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 2L,
				column: "Name",
				value: null);

			migrationBuilder.UpdateData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 3L,
				column: "Name",
				value: null);

			migrationBuilder.UpdateData(
				table: "Products",
				keyColumn: "Id",
				keyValue: 1L,
				column: "Name",
				value: null);

			migrationBuilder.UpdateData(
				table: "Products",
				keyColumn: "Id",
				keyValue: 2L,
				column: "Name",
				value: null);

			migrationBuilder.UpdateData(
				table: "Products",
				keyColumn: "Id",
				keyValue: 3L,
				column: "Name",
				value: null);

			migrationBuilder.UpdateData(
				table: "Sellers",
				keyColumn: "Id",
				keyValue: 1L,
				column: "Name",
				value: null);

			migrationBuilder.UpdateData(
				table: "Sellers",
				keyColumn: "Id",
				keyValue: 2L,
				column: "Name",
				value: null);

			migrationBuilder.UpdateData(
				table: "Sellers",
				keyColumn: "Id",
				keyValue: 3L,
				column: "Name",
				value: null);
		}
	}
}
