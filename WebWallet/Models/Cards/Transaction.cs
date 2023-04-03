using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using WebWallet.Models.Records;

namespace WebWallet.Models.Cards
{
    public class Transaction
    {
        [Key]
        [Required]
        public int TransactionID { get; set; }
        [Required]
        public Decimal Value { get; set; }
        [Required]
        public int InvoiceID { get; set; }
        public virtual Invoice Invoice { get; set; }
        [Required]
        public int RecordSubcategoryID { get; set; }
        public virtual RecordSubcategory RecordSubcategory { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}
