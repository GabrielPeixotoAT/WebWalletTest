using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebWallet.Data.DTO.Invoices;
using WebWallet.Data.Result;

namespace WebWallet.Services.Cards.Interfaces
{
    public interface IInvoiceService
    {
        Result<CreateInvoiceDTO> Create(CreateInvoiceDTO createInvoice, string userID);
        List<ReadInvoiceDTO> GetByCard(int cardID, string userID);
        ReadInvoiceDTO GetByID (int id, string userID);
    }
}