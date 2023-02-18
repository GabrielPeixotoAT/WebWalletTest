using Microsoft.AspNetCore.Mvc;
using WebWallet.Data;
using WebWallet.Data.DTO.AccountType;
using WebWallet.Models.Accounts;
using WebWallet.Services.Accounts.Interfaces;

namespace WebWallet.Services.Accounts
{
    public class AccountTypeService : IAccountTypeService
    {
        ApplicationDbContext context;

        public AccountTypeService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public AccountType? ReadById(int id)
        {
            return context.AccountTypes.FirstOrDefault(at => at.AccountTypeID == id);
        }
    }
}
