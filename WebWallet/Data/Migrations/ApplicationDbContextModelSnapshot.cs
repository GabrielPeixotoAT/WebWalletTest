﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebWallet.Data;

#nullable disable

namespace WebWallet.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("WebWallet.Models.Accounts.Account", b =>
                {
                    b.Property<int>("AccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountID"), 1L, 1);

                    b.Property<string>("AccountNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AccountTypeID")
                        .HasColumnType("int");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ColorCode")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("AccountID");

                    b.HasIndex("AccountTypeID");

                    b.HasIndex("UserId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("WebWallet.Models.Accounts.AccountType", b =>
                {
                    b.Property<int>("AccountTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountTypeID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountTypeID");

                    b.ToTable("AccountTypes");

                    b.HasData(
                        new
                        {
                            AccountTypeID = 1,
                            Description = "Dinheiro"
                        },
                        new
                        {
                            AccountTypeID = 2,
                            Description = "Conta Corrente"
                        },
                        new
                        {
                            AccountTypeID = 3,
                            Description = "Conta Poupança"
                        },
                        new
                        {
                            AccountTypeID = 4,
                            Description = "Conta em Corretora"
                        });
                });

            modelBuilder.Entity("WebWallet.Models.Cards.Bank", b =>
                {
                    b.Property<int>("BankID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BankID"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("BankID");

                    b.HasIndex("UserID");

                    b.ToTable("Banks");
                });

            modelBuilder.Entity("WebWallet.Models.Cards.Card", b =>
                {
                    b.Property<int>("CardID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CardID"), 1L, 1);

                    b.Property<int>("BankID")
                        .HasColumnType("int");

                    b.Property<string>("ColorCode")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<string>("ExpiringDate")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("InvoicesDueDate")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<decimal>("Limit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CardID");

                    b.HasIndex("BankID");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("WebWallet.Models.Cards.Invoice", b =>
                {
                    b.Property<int>("InvoiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvoiceID"), 1L, 1);

                    b.Property<int>("CardID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("FinancialCharges")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("InvoiceStatusID")
                        .HasColumnType("int");

                    b.Property<decimal>("Limit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Taxes")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("InvoiceID");

                    b.HasIndex("CardID");

                    b.HasIndex("InvoiceStatusID");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("WebWallet.Models.Cards.InvoiceStatus", b =>
                {
                    b.Property<int>("InvoiceStatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvoiceStatusID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InvoiceStatusID");

                    b.ToTable("InvoiceStatus");

                    b.HasData(
                        new
                        {
                            InvoiceStatusID = 1,
                            Description = "Aberta"
                        },
                        new
                        {
                            InvoiceStatusID = 2,
                            Description = "Vencida"
                        },
                        new
                        {
                            InvoiceStatusID = 3,
                            Description = "Parcialmente Paga"
                        },
                        new
                        {
                            InvoiceStatusID = 4,
                            Description = "Paga"
                        },
                        new
                        {
                            InvoiceStatusID = 5,
                            Description = "Cancelada"
                        },
                        new
                        {
                            InvoiceStatusID = 6,
                            Description = "Atrasada"
                        });
                });

            modelBuilder.Entity("WebWallet.Models.Cards.Transaction", b =>
                {
                    b.Property<int>("TransactionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionID"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("InvoiceID")
                        .HasColumnType("int");

                    b.Property<int>("RecordSubcategoryID")
                        .HasColumnType("int");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("TransactionID");

                    b.HasIndex("InvoiceID");

                    b.HasIndex("RecordSubcategoryID");

                    b.ToTable("Transaction");
                });

            modelBuilder.Entity("WebWallet.Models.Records.Record", b =>
                {
                    b.Property<int>("RecordID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecordID"), 1L, 1);

                    b.Property<int>("AccountID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("RecordSubcategoryID")
                        .HasColumnType("int");

                    b.Property<int>("RecordTypeID")
                        .HasColumnType("int");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("RecordID");

                    b.HasIndex("AccountID");

                    b.HasIndex("RecordSubcategoryID");

                    b.HasIndex("RecordTypeID");

                    b.ToTable("Records");
                });

            modelBuilder.Entity("WebWallet.Models.Records.RecordCategory", b =>
                {
                    b.Property<int>("RecordCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecordCategoryID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("RecordCategoryID");

                    b.ToTable("RecordCategories");

                    b.HasData(
                        new
                        {
                            RecordCategoryID = 1,
                            Description = "Alimentação"
                        },
                        new
                        {
                            RecordCategoryID = 2,
                            Description = "Compras"
                        },
                        new
                        {
                            RecordCategoryID = 3,
                            Description = "Despesas Financeiras"
                        },
                        new
                        {
                            RecordCategoryID = 4,
                            Description = "Investimentos"
                        },
                        new
                        {
                            RecordCategoryID = 5,
                            Description = "Moradia"
                        },
                        new
                        {
                            RecordCategoryID = 6,
                            Description = "Transporte"
                        },
                        new
                        {
                            RecordCategoryID = 7,
                            Description = "Social"
                        });
                });

            modelBuilder.Entity("WebWallet.Models.Records.RecordSubcategory", b =>
                {
                    b.Property<int>("RecordSubcategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecordSubcategoryID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("RecordCategoryID")
                        .HasColumnType("int");

                    b.HasKey("RecordSubcategoryID");

                    b.HasIndex("RecordCategoryID");

                    b.ToTable("RecordSubcategories");

                    b.HasData(
                        new
                        {
                            RecordSubcategoryID = 1,
                            Description = "Refeições",
                            RecordCategoryID = 1
                        },
                        new
                        {
                            RecordSubcategoryID = 2,
                            Description = "Fastfood",
                            RecordCategoryID = 1
                        },
                        new
                        {
                            RecordSubcategoryID = 3,
                            Description = "Bebida",
                            RecordCategoryID = 1
                        },
                        new
                        {
                            RecordSubcategoryID = 4,
                            Description = "Bebidas Alcoólicas",
                            RecordCategoryID = 1
                        },
                        new
                        {
                            RecordSubcategoryID = 5,
                            Description = "Bem-estar e Saúde",
                            RecordCategoryID = 2
                        },
                        new
                        {
                            RecordSubcategoryID = 6,
                            Description = "Casa",
                            RecordCategoryID = 2
                        },
                        new
                        {
                            RecordSubcategoryID = 7,
                            Description = "Eletrônicos",
                            RecordCategoryID = 2
                        },
                        new
                        {
                            RecordSubcategoryID = 8,
                            Description = "Papelaria e Escritório",
                            RecordCategoryID = 2
                        },
                        new
                        {
                            RecordSubcategoryID = 9,
                            Description = "Presentes",
                            RecordCategoryID = 2
                        },
                        new
                        {
                            RecordSubcategoryID = 10,
                            Description = "Empréstimos",
                            RecordCategoryID = 3
                        },
                        new
                        {
                            RecordSubcategoryID = 11,
                            Description = "Cobranças",
                            RecordCategoryID = 3
                        },
                        new
                        {
                            RecordSubcategoryID = 12,
                            Description = "Impostos",
                            RecordCategoryID = 3
                        },
                        new
                        {
                            RecordSubcategoryID = 13,
                            Description = "Ativos, Ações, Títulos",
                            RecordCategoryID = 4
                        },
                        new
                        {
                            RecordSubcategoryID = 14,
                            Description = "Imóveis",
                            RecordCategoryID = 4
                        },
                        new
                        {
                            RecordSubcategoryID = 15,
                            Description = "Poupança",
                            RecordCategoryID = 4
                        },
                        new
                        {
                            RecordSubcategoryID = 16,
                            Description = "Aluguel",
                            RecordCategoryID = 5
                        },
                        new
                        {
                            RecordSubcategoryID = 17,
                            Description = "Contas",
                            RecordCategoryID = 5
                        },
                        new
                        {
                            RecordSubcategoryID = 18,
                            Description = "Manutenção",
                            RecordCategoryID = 5
                        },
                        new
                        {
                            RecordSubcategoryID = 19,
                            Description = "Serviços",
                            RecordCategoryID = 5
                        },
                        new
                        {
                            RecordSubcategoryID = 20,
                            Description = "Viagens",
                            RecordCategoryID = 6
                        },
                        new
                        {
                            RecordSubcategoryID = 21,
                            Description = "Táxi",
                            RecordCategoryID = 6
                        },
                        new
                        {
                            RecordSubcategoryID = 22,
                            Description = "Transporte Público",
                            RecordCategoryID = 6
                        },
                        new
                        {
                            RecordSubcategoryID = 23,
                            Description = "Cultura",
                            RecordCategoryID = 7
                        },
                        new
                        {
                            RecordSubcategoryID = 24,
                            Description = "Eventos",
                            RecordCategoryID = 7
                        },
                        new
                        {
                            RecordSubcategoryID = 25,
                            Description = "Passatempos",
                            RecordCategoryID = 7
                        });
                });

            modelBuilder.Entity("WebWallet.Models.Records.RecordType", b =>
                {
                    b.Property<int>("RecordTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecordTypeID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("RecordTypeID");

                    b.ToTable("RecordTypes");

                    b.HasData(
                        new
                        {
                            RecordTypeID = 1,
                            Description = "Despesa"
                        },
                        new
                        {
                            RecordTypeID = 2,
                            Description = "Receita"
                        },
                        new
                        {
                            RecordTypeID = 3,
                            Description = "Transferência"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebWallet.Models.Accounts.Account", b =>
                {
                    b.HasOne("WebWallet.Models.Accounts.AccountType", "AccountType")
                        .WithMany("Accounts")
                        .HasForeignKey("AccountTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebWallet.Models.Cards.Bank", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebWallet.Models.Cards.Card", b =>
                {
                    b.HasOne("WebWallet.Models.Cards.Bank", "Bank")
                        .WithMany("Cards")
                        .HasForeignKey("BankID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bank");
                });

            modelBuilder.Entity("WebWallet.Models.Cards.Invoice", b =>
                {
                    b.HasOne("WebWallet.Models.Cards.Card", "Card")
                        .WithMany("Invoices")
                        .HasForeignKey("CardID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebWallet.Models.Cards.InvoiceStatus", "InvoiceStatus")
                        .WithMany()
                        .HasForeignKey("InvoiceStatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");

                    b.Navigation("InvoiceStatus");
                });

            modelBuilder.Entity("WebWallet.Models.Cards.Transaction", b =>
                {
                    b.HasOne("WebWallet.Models.Cards.Invoice", "Invoice")
                        .WithMany("Transactions")
                        .HasForeignKey("InvoiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebWallet.Models.Records.RecordSubcategory", "RecordSubcategory")
                        .WithMany()
                        .HasForeignKey("RecordSubcategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Invoice");

                    b.Navigation("RecordSubcategory");
                });

            modelBuilder.Entity("WebWallet.Models.Records.Record", b =>
                {
                    b.HasOne("WebWallet.Models.Accounts.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebWallet.Models.Records.RecordSubcategory", "RecordSubcategory")
                        .WithMany()
                        .HasForeignKey("RecordSubcategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebWallet.Models.Records.RecordType", "RecordType")
                        .WithMany("Records")
                        .HasForeignKey("RecordTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("RecordSubcategory");

                    b.Navigation("RecordType");
                });

            modelBuilder.Entity("WebWallet.Models.Records.RecordSubcategory", b =>
                {
                    b.HasOne("WebWallet.Models.Records.RecordCategory", "RecordCategory")
                        .WithMany("RecordSubcategory")
                        .HasForeignKey("RecordCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RecordCategory");
                });

            modelBuilder.Entity("WebWallet.Models.Accounts.AccountType", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("WebWallet.Models.Cards.Bank", b =>
                {
                    b.Navigation("Cards");
                });

            modelBuilder.Entity("WebWallet.Models.Cards.Card", b =>
                {
                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("WebWallet.Models.Cards.Invoice", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("WebWallet.Models.Records.RecordCategory", b =>
                {
                    b.Navigation("RecordSubcategory");
                });

            modelBuilder.Entity("WebWallet.Models.Records.RecordType", b =>
                {
                    b.Navigation("Records");
                });
#pragma warning restore 612, 618
        }
    }
}
