using Microsoft.EntityFrameworkCore;
using WebWallet.Models.Accounts;
using WebWallet.Models.Cards;
using WebWallet.Models.Records;

namespace WebWallet.Data.Seeders
{
    public class DBSeeder
    {
        public static void Seed(ModelBuilder builder)
        {
            SeedAccountType(builder);
            SeedRecordType(builder);
            SeedRecordCategory(builder);
            SeedRecordSubCatedory(builder);
            SeedInvoiceStatus(builder);
        }

        static void SeedAccountType(ModelBuilder builder)
        {
            List<AccountType> accountTypes = new List<AccountType>
            {
                new AccountType()
                {
                    AccountTypeID = 1,
                    Description = "Dinheiro"
                },
                new AccountType()
                {
                    AccountTypeID = 2,
                    Description = "Conta Corrente"
                },
                new AccountType()
                {
                    AccountTypeID = 3,
                    Description = "Conta Poupança"
                },
                new AccountType()
                {
                    AccountTypeID = 4,
                    Description = "Conta em Corretora"
                }
            };

            builder.Entity<AccountType>().HasData(accountTypes);
        }

        static void SeedRecordType(ModelBuilder builder)
        {
            List<RecordType> recordTypes = new List<RecordType>()
            {
                new RecordType()
                {
                    RecordTypeID = 1,
                    Description = "Despesa"
                },
                new RecordType()
                {
                    RecordTypeID = 2,
                    Description = "Receita"
                },
                new RecordType()
                {
                    RecordTypeID = 3,
                    Description = "Transferência"
                }
            };

            builder.Entity<RecordType>().HasData(recordTypes);
        }

        static void SeedRecordCategory(ModelBuilder builder)
        {
            List<RecordCategory> recordCategories = new List<RecordCategory>()
            {
                new RecordCategory()
                {
                    RecordCategoryID = 1,
                    Description = "Alimentação"
                },
                new RecordCategory()
                {
                    RecordCategoryID = 2,
                    Description = "Compras"
                },
                new RecordCategory()
                {
                    RecordCategoryID = 3,
                    Description = "Despesas Financeiras"
                },
                new RecordCategory()
                {
                    RecordCategoryID = 4,
                    Description = "Investimentos"
                },
                new RecordCategory()
                {
                    RecordCategoryID = 5,
                    Description = "Moradia"
                },
                new RecordCategory()
                {
                    RecordCategoryID = 6,
                    Description = "Transporte"
                },
                new RecordCategory()
                {
                    RecordCategoryID = 7,
                    Description = "Social"
                }
            };

            builder.Entity<RecordCategory>().HasData(recordCategories);
        }

        static void SeedRecordSubCatedory(ModelBuilder builder)
        {
            List<RecordSubcategory> recordSubcategories = new List<RecordSubcategory>()
            {
                new RecordSubcategory()
                {
                    RecordSubcategoryID = 1,
                    Description = "Refeições",
                    RecordCategoryID = 1
                },
                new RecordSubcategory()
                {
                    RecordSubcategoryID = 2,
                    Description = "Fastfood",
                    RecordCategoryID = 1
                },
                new RecordSubcategory()
                {
                    RecordSubcategoryID = 3,
                    Description = "Bebida",
                    RecordCategoryID = 1
                },
                new RecordSubcategory()
                {
                    RecordSubcategoryID = 4,
                    Description = "Bebidas Alcoólicas",
                    RecordCategoryID = 1
                },

                new RecordSubcategory()
                {
                    RecordSubcategoryID = 5,
                    Description = "Bem-estar e Saúde",
                    RecordCategoryID = 2
                },
                new RecordSubcategory()
                {
                    RecordSubcategoryID = 6,
                    Description = "Casa",
                    RecordCategoryID = 2
                },
                new RecordSubcategory()
                {
                    RecordSubcategoryID = 7,
                    Description = "Eletrônicos",
                    RecordCategoryID = 2
                },
                new RecordSubcategory()
                {
                    RecordSubcategoryID = 8,
                    Description = "Papelaria e Escritório",
                    RecordCategoryID = 2
                },
                new RecordSubcategory()
                {
                    RecordSubcategoryID = 9,
                    Description = "Presentes",
                    RecordCategoryID = 2
                },

                new RecordSubcategory()
                {
                    RecordSubcategoryID = 10,
                    Description = "Empréstimos",
                    RecordCategoryID = 3
                },
                new RecordSubcategory()
                {
                    RecordSubcategoryID = 11,
                    Description = "Cobranças",
                    RecordCategoryID = 3
                },
                new RecordSubcategory()
                {
                    RecordSubcategoryID = 12,
                    Description = "Impostos",
                    RecordCategoryID = 3
                },
                new RecordSubcategory()
                {
                    RecordSubcategoryID = 13,
                    Description = "Transferências",
                    RecordCategoryID = 3
                },

                new RecordSubcategory()
                {
                    RecordSubcategoryID = 14,
                    Description = "Ativos, Ações, Títulos",
                    RecordCategoryID = 4
                },
                new RecordSubcategory()
                {
                    RecordSubcategoryID = 15,
                    Description = "Imóveis",
                    RecordCategoryID = 4
                },
                new RecordSubcategory()
                {
                    RecordSubcategoryID = 16,
                    Description = "Poupança",
                    RecordCategoryID = 4
                },

                new RecordSubcategory()
                {
                    RecordSubcategoryID = 17,
                    Description = "Aluguel",
                    RecordCategoryID = 5
                },
                new RecordSubcategory()
                {
                    RecordSubcategoryID = 18,
                    Description = "Contas",
                    RecordCategoryID = 5
                },
                new RecordSubcategory()
                {
                    RecordSubcategoryID = 19,
                    Description = "Manutenção",
                    RecordCategoryID = 5
                },
                new RecordSubcategory()
                {
                    RecordSubcategoryID = 20,
                    Description = "Serviços",
                    RecordCategoryID = 5
                },

                new RecordSubcategory()
                {
                    RecordSubcategoryID = 21,
                    Description = "Viagens",
                    RecordCategoryID = 6
                },
                new RecordSubcategory()
                {
                    RecordSubcategoryID = 22,
                    Description = "Táxi",
                    RecordCategoryID = 6
                },
                new RecordSubcategory()
                {
                    RecordSubcategoryID = 23,
                    Description = "Transporte Público",
                    RecordCategoryID = 6
                },

                new RecordSubcategory()
                {
                    RecordSubcategoryID = 24,
                    Description = "Cultura",
                    RecordCategoryID = 7
                },
                new RecordSubcategory()
                {
                    RecordSubcategoryID = 25,
                    Description = "Eventos",
                    RecordCategoryID = 7
                },
                new RecordSubcategory()
                {
                    RecordSubcategoryID = 26,
                    Description = "Passatempos",
                    RecordCategoryID = 7
                }
            };

            builder.Entity<RecordSubcategory>().HasData(recordSubcategories);
        }

        static void SeedInvoiceStatus(ModelBuilder modelBuilder)
        {
            List<InvoiceStatus> invoiceStatus = new List<InvoiceStatus>()
            {
                new InvoiceStatus()
                {
                    InvoiceStatusID = 1,
                    Description = "Aberta"
                },
                new InvoiceStatus()
                {
                    InvoiceStatusID = 2,
                    Description = "Vencida"
                },
                new InvoiceStatus()
                {
                    InvoiceStatusID = 3,
                    Description = "Parcialmente Paga"
                },
                new InvoiceStatus()
                {
                    InvoiceStatusID = 4,
                    Description = "Paga"
                },
                new InvoiceStatus()
                {
                    InvoiceStatusID = 5,
                    Description = "Cancelada"
                },
                new InvoiceStatus()
                {
                    InvoiceStatusID = 6,
                    Description = "Atrasada"
                }
            };

            modelBuilder.Entity<InvoiceStatus>().HasData(invoiceStatus);
        }
    }
}
