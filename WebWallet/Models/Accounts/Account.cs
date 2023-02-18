using System.ComponentModel.DataAnnotations;

namespace WebWallet.Models.Accounts
{
    public class Account
    {
        [Key]
        [Required]
        public int AccountID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Decimal Amount { get; set; }
        [Required]
        public string AccountNumber { get; set; }

        public AccountType AccountType { get; set; }
    }
}
