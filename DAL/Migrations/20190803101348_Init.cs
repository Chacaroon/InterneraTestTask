using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
	public partial class Init : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "Companies",
				columns: table => new
				{
					Id = table.Column<long>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Companies", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Customers",
				columns: table => new
				{
					Id = table.Column<long>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Customers", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Products",
				columns: table => new
				{
					Id = table.Column<long>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Products", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Sellers",
				columns: table => new
				{
					Id = table.Column<long>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
					CompanyId = table.Column<long>(nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Sellers", x => x.Id);
					table.ForeignKey(
						name: "FK_Sellers_Companies_CompanyId",
						column: x => x.CompanyId,
						principalTable: "Companies",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "Deals",
				columns: table => new
				{
					Id = table.Column<long>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
					ProductAmount = table.Column<int>(nullable: false),
					SellerId = table.Column<long>(nullable: false),
					CustomerId = table.Column<long>(nullable: false),
					ProductId = table.Column<long>(nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Deals", x => x.Id);
					table.ForeignKey(
						name: "FK_Deals_Customers_CustomerId",
						column: x => x.CustomerId,
						principalTable: "Customers",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_Deals_Products_ProductId",
						column: x => x.ProductId,
						principalTable: "Products",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_Deals_Sellers_SellerId",
						column: x => x.SellerId,
						principalTable: "Sellers",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateIndex(
				name: "IX_Deals_CustomerId",
				table: "Deals",
				column: "CustomerId");

			migrationBuilder.CreateIndex(
				name: "IX_Deals_ProductId",
				table: "Deals",
				column: "ProductId");

			migrationBuilder.CreateIndex(
				name: "IX_Deals_SellerId",
				table: "Deals",
				column: "SellerId");

			migrationBuilder.CreateIndex(
				name: "IX_Sellers_CompanyId",
				table: "Sellers",
				column: "CompanyId");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "Deals");

			migrationBuilder.DropTable(
				name: "Customers");

			migrationBuilder.DropTable(
				name: "Products");

			migrationBuilder.DropTable(
				name: "Sellers");

			migrationBuilder.DropTable(
				name: "Companies");
		}
	}
}
