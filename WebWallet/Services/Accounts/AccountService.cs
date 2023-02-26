using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebWallet.Data;
using WebWallet.Data.DTO.Accounts;
using WebWallet.Data.DTO.AccountType;
using WebWallet.Data.Result;
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
            AccountType? accountType = accountTypeService.ReadById(createAccoutDTO.AccountTypeId);
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

        public Result<UpdateAccountDTO> Update(UpdateAccountDTO request)
        {
            Account? accountUpdate = GetByID(request.AccountID);

            if(accountUpdate == null)
                return new ErrorResult<UpdateAccountDTO>(request, "Account not found");

            accountUpdate.Name = request.Name;
            accountUpdate.AccountNumber = request.AccountNumber;
            accountUpdate.Amount = request.Amount;
            accountUpdate.AccountTypeID = request.AccountTypeId;

            context.SaveChanges();

            return new SuccessResult<UpdateAccountDTO>(request);
        }

        public bool Delete(int id)
        {
            Account? account = context.Accounts.FirstOrDefault(account => account.AccountID == id);
            
            if(account == null)
                return false;

            context.Accounts.Remove(account);
            context.SaveChanges();

            return true;
        }

        public List<ReadAccountDTO> GetAll(string userId)
        {
            List < ReadAccountDTO > list = mapper.Map<List<ReadAccountDTO>>(context.Accounts.ToList());
            return mapper.Map<List<ReadAccountDTO>>(context.Accounts.ToList());
        }

        public Account? GetByID(int id)
        {
            return context.Accounts.FirstOrDefault(account => account.AccountID == id);
        }
    }
}
