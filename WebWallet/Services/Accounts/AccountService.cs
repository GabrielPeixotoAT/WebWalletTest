using AutoMapper;
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
        IMapper mapper;

        IAccountTypeService accountTypeService;

        public AccountService(ApplicationDbContext context, IAccountTypeService accountTypeService, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
            this.accountTypeService = accountTypeService;
        }

        public ActionResult<CreateAccountDTO> Create (CreateAccountDTO createAccoutDTO)
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

        public List<ReadAccountDTO> GetAll()
        {
            return mapper.Map<List<ReadAccountDTO>>(context.Accounts.ToList());
        }
    }
}
