using WebWallet.Data.DTO.Bank;
using WebWallet.Data.DTO.Card;
using WebWallet.Data.DTO.Invoices;
using WebWallet.Data.DTO.InvoiceStatus;

namespace WebWallet.Models.ViewModels
{
    public class CardDetailViewModel
    {
        public List<ReadBankDTO> Banks { get; set; }
        public ReadCardDTO Card { get; set; }
        public List<ReadInvoiceDTO> Invoices { get; set; }
        public List<ReadInvoiceStatusDTO> InvoicesStatus { get; set; }
    }
}
