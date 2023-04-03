using System.ComponentModel.DataAnnotations;

namespace WebWallet.Data.DTO.Transaction
{
    public class ReadTransactionDTO
    {
        [Required]
        public int TransactionID { get; set; }
        [Required]
        public Decimal Value { get; set; }
        [Required]
        public int InvoiceID { get; set; }
        [Required]
        public int RecordSubcategoryID { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}
