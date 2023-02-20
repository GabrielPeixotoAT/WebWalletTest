using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebWallet.Models.Accounts;
using WebWallet.Models.Records;

namespace WebWallet.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<RecordType> RecordTypes { get; set; }
        public DbSet<RecordCategory> RecordCategories { get; set; }
        public DbSet<RecordSubcategory> RecordSubcategories { get; set; }
        public DbSet<Record> Records { get; set; }
    }
}