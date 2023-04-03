using System.ComponentModel.DataAnnotations;
using WebWallet.Models.Cards;

namespace WebWallet.Data.DTO.Invoices
{
    public class CreateInvoiceDTO
    {
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
