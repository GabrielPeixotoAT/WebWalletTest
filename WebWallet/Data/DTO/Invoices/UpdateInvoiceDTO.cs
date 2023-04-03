using System.ComponentModel.DataAnnotations;
using WebWallet.Models.Cards;

namespace WebWallet.Data.DTO.Invoices
{
    public class UpdateInvoiceDTO
    {
        [Required]
        public int InvoiceID { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public int InvoiceStatusID { get; set; }
        [Required]
        public int CardID { get; set; }
    }
}
