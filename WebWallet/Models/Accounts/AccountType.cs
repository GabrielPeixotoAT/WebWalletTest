using System.ComponentModel.DataAnnotations;

namespace WebWallet.Models.Accounts
{
    public class AccountType
    {
        [Key]
        [Required]
        public int AccountTypeID { get; set; }
        [Required]
        public string Description { get; set; }

        public virtual List<Account> Accounts { get; set; }
    }
}
