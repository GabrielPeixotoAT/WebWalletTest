using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebWallet.Models.Cards
{
    public class Card
    {
        [Key]
        [Required]
        public int CardID { get; set; }
        [Required]
        public string Number { get; set; }
        [Required]
        public int BankID { get; set; }
        public virtual Bank Bank { get; set; }
        [Required]
        [StringLength(5)]
        public string ExpiringDate { get; set; }
        [Required]
        public Decimal Limit { get; set; }
        [Required]
        [StringLength(2)]
        public string InvoicesDueDate { get; set; }
        
        public virtual List<Invoice> Invoices { get; set; }
    }
}
