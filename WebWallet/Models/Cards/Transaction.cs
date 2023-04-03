using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebWallet.Models.Cards
{
    public class Transaction
    {
        [Key]
        [Required]
        public int TransactionID { get; set; }
        [Required]
        public Decimal Value { get; set; }
    }
}
