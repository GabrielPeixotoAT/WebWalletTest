using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WebWallet.Data.DTO.Invoices;
using WebWallet.Models.Cards;

namespace WebWallet.Profiles.Cards
{
    public class InvoiceProfile : Profile
    {
        public InvoiceProfile()
        {
            CreateMap<CreateInvoiceDTO, Invoice>();
            CreateMap<Invoice, ReadInvoiceDTO>();
            CreateMap<UpdateInvoiceDTO, Invoice>();
        }
    }
}