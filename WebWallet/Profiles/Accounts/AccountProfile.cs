using AutoMapper;
using WebWallet.Data.DTO.Accounts;
using WebWallet.Models.Accounts;

namespace WebWallet.Profiles.Accounts
{
    public class AccountProfile : Profile 
    {
        public AccountProfile() 
        {
            CreateMap<CreateAccountDTO, Account>();
            CreateMap<Account, ReadAccountDTO>();
            CreateMap<UpdateAccountDTO, Account>();
        }
    }
}
