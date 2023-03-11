using AutoMapper;
using WebWallet.Data.DTO.AccountType;
using WebWallet.Models.Accounts;

namespace WebWallet.Profiles.Accounts
{
    public class AccountTypeProfile : Profile
    {
        public AccountTypeProfile() 
        {
            CreateMap<AccountType, ReadAccountTypeDTO>();
        }
    }
}
