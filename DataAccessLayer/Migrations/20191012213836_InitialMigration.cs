using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
	public partial class InitialMigration : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "Categories",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(maxLength: 24, nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Categories", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Users",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Email = table.Column<string>(maxLength: 64, nullable: false),
					Sha256Password = table.Column<string>(maxLength: 256, nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Users", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Spendings",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(maxLength: 24, nullable: false),
					Description = table.Column<string>(maxLength: 256, nullable: false),
					CreationTime = table.Column<DateTime>(nullable: false),
					CategoryId = table.Column<int>(nullable: false),
					UserId = table.Column<int>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Spendings", x => x.Id);
					table.ForeignKey(
						name: "FK_Spendings_Categories_CategoryId",
						column: x => x.CategoryId,
						principalTable: "Categories",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_Spendings_Users_UserId",
						column: x => x.UserId,
						principalTable: "Users",
						principalColumn: "Id",
						onDelete: ReferentialAction.Restrict);
				});

			migrationBuilder.CreateTable(
				name: "Tags",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(maxLength: 24, nullable: false),
					SpendingId = table.Column<int>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Tags", x => x.Id);
					table.ForeignKey(
						name: "FK_Tags_Spendings_SpendingId",
						column: x => x.SpendingId,
						principalTable: "Spendings",
						principalColumn: "Id",
						onDelete: ReferentialAction.Restrict);
				});

			migrationBuilder.CreateIndex(
				name: "IX_Spendings_CategoryId",
				table: "Spendings",
				column: "CategoryId");

			migrationBuilder.CreateIndex(
				name: "IX_Spendings_UserId",
				table: "Spendings",
				column: "UserId");

			migrationBuilder.CreateIndex(
				name: "IX_Tags_SpendingId",
				table: "Tags",
				column: "SpendingId");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "Tags");

			migrationBuilder.DropTable(
				name: "Spendings");

			migrationBuilder.DropTable(
				name: "Categories");

			migrationBuilder.DropTable(
				name: "Users");
		}
	}
}
