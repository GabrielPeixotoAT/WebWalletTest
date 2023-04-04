using Microsoft.AspNetCore.Identity;
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
        [Required]
        public int AccountTypeID { get; set; }
        public virtual AccountType AccountType { get; set; }
        [Required]
        public string UserId { get; set; }
        public virtual IdentityUser User { get; set; }
        [Required]
        [StringLength(7)]
        public string ColorCode { get; set; }
    }
}
