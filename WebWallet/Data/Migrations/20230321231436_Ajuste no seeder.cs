using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebWallet.Data.Migrations
{
    public partial class Ajustenoseeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RecordSubcategories",
                columns: new[] { "RecordSubcategoryID", "Description", "RecordCategoryID" },
                values: new object[,]
                {
                    { 1, "Refeições", 1 },
                    { 2, "Fastfood", 1 },
                    { 3, "Bebida", 1 },
                    { 4, "Bebidas Alcoólicas", 1 },
                    { 5, "Bem-estar e Saúde", 2 },
                    { 6, "Casa", 2 },
                    { 7, "Eletrônicos", 2 },
                    { 8, "Papelaria e Escritório", 2 },
                    { 9, "Presentes", 2 },
                    { 10, "Empréstimos", 3 },
                    { 11, "Cobranças", 3 },
                    { 12, "Impostos", 3 },
                    { 13, "Ativos, Ações, Títulos", 4 },
                    { 14, "Imóveis", 4 },
                    { 15, "Poupança", 4 },
                    { 16, "Aluguel", 5 },
                    { 17, "Contas", 5 },
                    { 18, "Manutenção", 5 },
                    { 19, "Serviços", 5 },
                    { 20, "Viagens", 6 },
                    { 21, "Táxi", 6 },
                    { 22, "Transporte Público", 6 },
                    { 23, "Cultura", 7 },
                    { 24, "Eventos", 7 },
                    { 25, "Passatempos", 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RecordSubcategories",
                keyColumn: "RecordSubcategoryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RecordSubcategories",
                keyColumn: "RecordSubcategoryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RecordSubcategories",
                keyColumn: "RecordSubcategoryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RecordSubcategories",
                keyColumn: "RecordSubcategoryID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RecordSubcategories",
                keyColumn: "RecordSubcategoryID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RecordSubcategories",
                keyColumn: "RecordSubcategoryID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RecordSubcategories",
                keyColumn: "RecordSubcategoryID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RecordSubcategories",
                keyColumn: "RecordSubcategoryID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RecordSubcategories",
                keyColumn: "RecordSubcategoryID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "RecordSubcategories",
                keyColumn: "RecordSubcategoryID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "RecordSubcategories",
                keyColumn: "RecordSubcategoryID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "RecordSubcategories",
                keyColumn: "RecordSubcategoryID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "RecordSubcategories",
                keyColumn: "RecordSubcategoryID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "RecordSubcategories",
                keyColumn: "RecordSubcategoryID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "RecordSubcategories",
                keyColumn: "RecordSubcategoryID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "RecordSubcategories",
                keyColumn: "RecordSubcategoryID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "RecordSubcategories",
                keyColumn: "RecordSubcategoryID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "RecordSubcategories",
                keyColumn: "RecordSubcategoryID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "RecordSubcategories",
                keyColumn: "RecordSubcategoryID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "RecordSubcategories",
                keyColumn: "RecordSubcategoryID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "RecordSubcategories",
                keyColumn: "RecordSubcategoryID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "RecordSubcategories",
                keyColumn: "RecordSubcategoryID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "RecordSubcategories",
                keyColumn: "RecordSubcategoryID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "RecordSubcategories",
                keyColumn: "RecordSubcategoryID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "RecordSubcategories",
                keyColumn: "RecordSubcategoryID",
                keyValue: 25);
        }
    }
}
