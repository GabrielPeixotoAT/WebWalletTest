using WebWallet.Data.DTO.Invoices;
using WebWallet.Data.DTO.InvoiceStatus;

namespace WebWallet.Models.ViewModels
{
    public class InvoiceDetailViewModel
    {
        public ReadInvoiceDTO Invoice { get; set; }
        public List<ReadInvoiceStatusDTO> Status { get; set; }
    }
}
