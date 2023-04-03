using System.ComponentModel.DataAnnotations;

namespace WebWallet.Data.DTO.InvoiceStatus
{
    public class ReadInvoiceStatusDTO
    {
        [Required]
        public int InvoiceStatusID { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
