using System.ComponentModel.DataAnnotations;

namespace WebWallet.Data.DTO.Invoices
{
    public class CreateInvoiceDTO
    {
        [Required]
        public DateTime DueDate { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public Decimal FinancialCharges { get; set; }
        [Required]
        public Decimal Taxes { get; set; }
        [Required]
        public Decimal Limit { get; set; }
        [Required]
        public int InvoiceStatusID { get; set; }
        [Required]
        public int CardID { get; set; }
        [Required]
        public Decimal Value { get; set; }
    }
}
