using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebWallet.Data.Seeders;
using WebWallet.Models.Accounts;
using WebWallet.Models.Cards;
using WebWallet.Models.Records;

namespace WebWallet.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            DBSeeder.Seed(builder);
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<RecordType> RecordTypes { get; set; }
        public DbSet<RecordCategory> RecordCategories { get; set; }
        public DbSet<RecordSubcategory> RecordSubcategories { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Card> Cards { get; set; }
    }
}