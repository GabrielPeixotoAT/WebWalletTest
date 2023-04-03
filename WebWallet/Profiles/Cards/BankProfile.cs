using AutoMapper;
using WebWallet.Data.DTO.Bank;
using WebWallet.Models.Cards;

namespace WebWallet.Profiles.Cards
{
    public class BankProfile : Profile
    {
        public BankProfile()
        {
            CreateMap<Bank, ReadBankDTO>();
            CreateMap<CreateBankDTO, Bank>();
            CreateMap<UpdateBankDTO, Bank>();
        }
    }
}
