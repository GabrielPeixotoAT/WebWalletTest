using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebWallet.Models.Cards
{
    public class Bank
    {
        [Key]
        [Required]
        public int BankID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string UserID { get; set; }
        public virtual IdentityUser User { get; set; }
    }
}
