using System.ComponentModel.DataAnnotations;

namespace WebWallet.Models.Cards
{
    public class Invoice
    {
        [Key]
        [Required]
        public int InvoiceID { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public int InvoiceStatusID { get; set; }
        public virtual InvoiceStatus InvoiceStatus { get; set; }
        [Required]
        public int CardID { get; set; }
        public virtual Card Card { get; set; }
        public virtual List<Transaction> Transactions { get; set; }
    }
}
