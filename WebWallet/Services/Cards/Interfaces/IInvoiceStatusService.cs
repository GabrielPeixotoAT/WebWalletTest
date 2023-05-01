using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebWallet.Data.DTO.InvoiceStatus;

namespace WebWallet.Services.Cards.Interfaces
{
    public interface IInvoiceStatusService
    {
        List<ReadInvoiceStatusDTO> GetAll();
    }
}