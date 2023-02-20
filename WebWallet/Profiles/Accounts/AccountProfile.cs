using AutoMapper;
using WebWallet.Data.DTO.Accounts;
using WebWallet.Models.Accounts;

namespace WebWallet.Profiles.Accounts
{
    public class AccountProfile : Profile 
    {
        public AccountProfile() 
        {
            CreateMap<Account, ReadAccountDTO>();
        }
    }
}
