using AutoMapper;
using WebWallet.Data.DTO.InvoiceStatus;
using WebWallet.Models.Cards;

namespace WebWallet.Profiles.Cards
{
    public class InvoiceStatusProfile : Profile
    {
        public InvoiceStatusProfile()
        {
            CreateMap<InvoiceStatus, ReadInvoiceStatusDTO>();
        }
    }
}