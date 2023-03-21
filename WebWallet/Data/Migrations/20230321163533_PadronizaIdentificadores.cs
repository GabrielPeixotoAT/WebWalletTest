using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebWallet.Data.Migrations
{
    public partial class PadronizaIdentificadores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecordSubcategories_RecordCategories_RecordCategoryId",
                table: "RecordSubcategories");

            migrationBuilder.RenameColumn(
                name: "RecordCategoryId",
                table: "RecordSubcategories",
                newName: "RecordCategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_RecordSubcategories_RecordCategoryId",
                table: "RecordSubcategories",
                newName: "IX_RecordSubcategories_RecordCategoryID");

            migrationBuilder.RenameColumn(
                name: "RecordCategoryId",
                table: "RecordCategories",
                newName: "RecordCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_RecordSubcategories_RecordCategories_RecordCategoryID",
                table: "RecordSubcategories",
                column: "RecordCategoryID",
                principalTable: "RecordCategories",
                principalColumn: "RecordCategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecordSubcategories_RecordCategories_RecordCategoryID",
                table: "RecordSubcategories");

            migrationBuilder.RenameColumn(
                name: "RecordCategoryID",
                table: "RecordSubcategories",
                newName: "RecordCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_RecordSubcategories_RecordCategoryID",
                table: "RecordSubcategories",
                newName: "IX_RecordSubcategories_RecordCategoryId");

            migrationBuilder.RenameColumn(
                name: "RecordCategoryID",
                table: "RecordCategories",
                newName: "RecordCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_RecordSubcategories_RecordCategories_RecordCategoryId",
                table: "RecordSubcategories",
                column: "RecordCategoryId",
                principalTable: "RecordCategories",
                principalColumn: "RecordCategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
