using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebWallet.Data.Migrations
{
    public partial class RelacionamentosComAtributosVirtuais : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AccountTypes",
                columns: new[] { "AccountTypeID", "Description" },
                values: new object[,]
                {
                    { 1, "Dinheiro" },
                    { 2, "Conta Corrente" },
                    { 3, "Conta Poupança" },
                    { 4, "Conta em Corretora" }
                });

            migrationBuilder.InsertData(
                table: "RecordCategories",
                columns: new[] { "RecordCategoryID", "Description" },
                values: new object[,]
                {
                    { 1, "Alimentação" },
                    { 2, "Compras" },
                    { 3, "Despesas Financeiras" },
                    { 4, "Investimentos" },
                    { 5, "Moradia" },
                    { 6, "Transporte" },
                    { 7, "Social" }
                });

            migrationBuilder.InsertData(
                table: "RecordTypes",
                columns: new[] { "RecordTypeID", "Description" },
                values: new object[,]
                {
                    { 1, "Despesa" },
                    { 2, "Receita" },
                    { 3, "Transferência" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AccountTypes",
                keyColumn: "AccountTypeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AccountTypes",
                keyColumn: "AccountTypeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AccountTypes",
                keyColumn: "AccountTypeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AccountTypes",
                keyColumn: "AccountTypeID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RecordCategories",
                keyColumn: "RecordCategoryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RecordCategories",
                keyColumn: "RecordCategoryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RecordCategories",
                keyColumn: "RecordCategoryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RecordCategories",
                keyColumn: "RecordCategoryID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RecordCategories",
                keyColumn: "RecordCategoryID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RecordCategories",
                keyColumn: "RecordCategoryID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RecordCategories",
                keyColumn: "RecordCategoryID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RecordTypes",
                keyColumn: "RecordTypeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RecordTypes",
                keyColumn: "RecordTypeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RecordTypes",
                keyColumn: "RecordTypeID",
                keyValue: 3);
        }
    }
}
