using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
	public partial class AddDataSeeding : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.InsertData(
				table: "Companies",
				column: "Id",
				values: new object[]
				{
					1L,
					2L,
					3L
				});

			migrationBuilder.InsertData(
				table: "Customers",
				column: "Id",
				values: new object[]
				{
					1L,
					2L,
					3L
				});

			migrationBuilder.InsertData(
				table: "Products",
				column: "Id",
				values: new object[]
				{
					1L,
					2L,
					3L
				});

			migrationBuilder.InsertData(
				table: "Sellers",
				columns: new[] { "Id", "CompanyId" },
				values: new object[] { 1L, 1L });

			migrationBuilder.InsertData(
				table: "Sellers",
				columns: new[] { "Id", "CompanyId" },
				values: new object[] { 2L, 2L });

			migrationBuilder.InsertData(
				table: "Sellers",
				columns: new[] { "Id", "CompanyId" },
				values: new object[] { 3L, 3L });

			migrationBuilder.InsertData(
				table: "Deals",
				columns: new[] { "Id", "CustomerId", "ProductAmount", "ProductId", "SellerId" },
				values: new object[] { 1L, 1L, 1, 1L, 1L });

			migrationBuilder.InsertData(
				table: "Deals",
				columns: new[] { "Id", "CustomerId", "ProductAmount", "ProductId", "SellerId" },
				values: new object[] { 2L, 2L, 2, 2L, 2L });

			migrationBuilder.InsertData(
				table: "Deals",
				columns: new[] { "Id", "CustomerId", "ProductAmount", "ProductId", "SellerId" },
				values: new object[] { 3L, 3L, 3, 3L, 3L });
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DeleteData(
				table: "Deals",
				keyColumn: "Id",
				keyValue: 1L);

			migrationBuilder.DeleteData(
				table: "Deals",
				keyColumn: "Id",
				keyValue: 2L);

			migrationBuilder.DeleteData(
				table: "Deals",
				keyColumn: "Id",
				keyValue: 3L);

			migrationBuilder.DeleteData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 1L);

			migrationBuilder.DeleteData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 2L);

			migrationBuilder.DeleteData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 3L);

			migrationBuilder.DeleteData(
				table: "Products",
				keyColumn: "Id",
				keyValue: 1L);

			migrationBuilder.DeleteData(
				table: "Products",
				keyColumn: "Id",
				keyValue: 2L);

			migrationBuilder.DeleteData(
				table: "Products",
				keyColumn: "Id",
				keyValue: 3L);

			migrationBuilder.DeleteData(
				table: "Sellers",
				keyColumn: "Id",
				keyValue: 1L);

			migrationBuilder.DeleteData(
				table: "Sellers",
				keyColumn: "Id",
				keyValue: 2L);

			migrationBuilder.DeleteData(
				table: "Sellers",
				keyColumn: "Id",
				keyValue: 3L);

			migrationBuilder.DeleteData(
				table: "Companies",
				keyColumn: "Id",
				keyValue: 1L);

			migrationBuilder.DeleteData(
				table: "Companies",
				keyColumn: "Id",
				keyValue: 2L);

			migrationBuilder.DeleteData(
				table: "Companies",
				keyColumn: "Id",
				keyValue: 3L);
		}
	}
}
