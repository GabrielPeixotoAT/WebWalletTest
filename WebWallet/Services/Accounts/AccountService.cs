using Microsoft.AspNetCore.Mvc;
using WebWallet.Data;
using WebWallet.Data.DTO.Accounts;
using WebWallet.Data.DTO.AccountType;
using WebWallet.Models.Accounts;
using WebWallet.Services.Accounts.Interfaces;

namespace WebWallet.Services.Accounts
{
    public class AccountService : IAccountService
    {
        ApplicationDbContext context;
        IAccountTypeService accountTypeService;

        public AccountService(ApplicationDbContext context, IAccountTypeService accountTypeService)
        {
            this.context = context;
            this.accountTypeService = accountTypeService;
        }

        public ActionResult<CreateAccoutDTO> Create (CreateAccoutDTO createAccoutDTO)
        {
            AccountType? accountType = accountTypeService.ReadById(createAccoutDTO.AccoutTypeId);
            if (accountType == null)
                return new NotFoundResult();

            Account account = new Account()
            {
                Name = createAccoutDTO.Name,
                Amount = createAccoutDTO.Amount,
                AccountNumber = createAccoutDTO.AccountNumber,
                AccountType = accountType
            };

            context.Accounts.Add(account);
            context.SaveChanges();

            return new CreatedResult("", createAccoutDTO);
        }
    }
}
