using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebWallet.Data.Migrations
{
    public partial class TablesForRecordLogic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RecordCategories",
                columns: table => new
                {
                    RecordCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecordCategories", x => x.RecordCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "RecordTypes",
                columns: table => new
                {
                    RecordTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecordTypes", x => x.RecordTypeId);
                });

            migrationBuilder.CreateTable(
                name: "RecordSubcategories",
                columns: table => new
                {
                    RecordSubcategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RecordCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecordSubcategories", x => x.RecordSubcategoryId);
                    table.ForeignKey(
                        name: "FK_RecordSubcategories_RecordCategories_RecordCategoryId",
                        column: x => x.RecordCategoryId,
                        principalTable: "RecordCategories",
                        principalColumn: "RecordCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    RecordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AccountID = table.Column<int>(type: "int", nullable: false),
                    RecordTypeId = table.Column<int>(type: "int", nullable: false),
                    RecordSubcategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Records", x => x.RecordId);
                    table.ForeignKey(
                        name: "FK_Records_Accounts_AccountID",
                        column: x => x.AccountID,
                        principalTable: "Accounts",
                        principalColumn: "AccountID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Records_RecordSubcategories_RecordSubcategoryId",
                        column: x => x.RecordSubcategoryId,
                        principalTable: "RecordSubcategories",
                        principalColumn: "RecordSubcategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Records_RecordTypes_RecordTypeId",
                        column: x => x.RecordTypeId,
                        principalTable: "RecordTypes",
                        principalColumn: "RecordTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Records_AccountID",
                table: "Records",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Records_RecordSubcategoryId",
                table: "Records",
                column: "RecordSubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_RecordTypeId",
                table: "Records",
                column: "RecordTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RecordSubcategories_RecordCategoryId",
                table: "RecordSubcategories",
                column: "RecordCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Records");

            migrationBuilder.DropTable(
                name: "RecordSubcategories");

            migrationBuilder.DropTable(
                name: "RecordTypes");

            migrationBuilder.DropTable(
                name: "RecordCategories");
        }
    }
}
