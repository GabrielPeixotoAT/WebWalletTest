using AutoMapper;
using WebWallet.Data;
using WebWallet.Data.DTO.Accounts;
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

        public Result<CreateAccountDTO> Create(CreateAccountDTO createAccoutDTO)
        {
            if (!AvailabilityForCreation(createAccoutDTO))
                return new ErrorResult<CreateAccountDTO>(createAccoutDTO, "This aacount cannot be created");

            Account account = mapper.Map<Account>(createAccoutDTO);

            context.Accounts.Add(account);
            context.SaveChanges();

            return new SuccessResult<CreateAccountDTO>(createAccoutDTO, "Created");
        }

        public Result<UpdateAccountDTO> Update(UpdateAccountDTO accountDTO)
        {
            Account? accountUpdate = GetByID(accountDTO.AccountID);

            if(accountUpdate == null || accountUpdate.UserId != accountUpdate.UserId)
                return new ErrorResult<UpdateAccountDTO>(accountDTO, "Account not found");

            accountUpdate.Name = accountDTO.Name;
            accountUpdate.Amount = accountDTO.Amount;
            accountUpdate.AccountNumber = accountDTO.AccountNumber;
            accountUpdate.AccountTypeID = accountDTO.AccountTypeID;
            accountUpdate.ColorCode = accountDTO.ColorCode;

            context.SaveChanges();

            return new SuccessResult<UpdateAccountDTO>(accountDTO);
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
            return mapper.Map<List<ReadAccountDTO>>(context.Accounts.Where(account => account.UserId == userId));
        }

        public Account? GetByID(int id)
        {
            return context.Accounts.FirstOrDefault(account => account.AccountID == id);
        }

        public ReadAccountDTO? GetByIDExternal(int id, string userId)
        {
            return mapper.Map<ReadAccountDTO>(context.Accounts.FirstOrDefault(account => account.AccountID == id && account.UserId == userId));
        }

        Account? GetByName(string name)
        {
            return context.Accounts.FirstOrDefault(account => account.Name == name);
        }

        bool AvailabilityForCreation(CreateAccountDTO accountDTO)
        {
            if (!AccountExistsForUser(accountDTO.Name, accountDTO.UserId) && AccountTypeExists(accountDTO.AccountTypeID))
                return true;

            return false;
        }

        bool AccountExistsForUser(string name, string userID)
        {
            Account? account = GetByName(name);

            if (account == null)
                return false;
            if (account.UserId != userID)
                return false;

            return true;
        }

        bool AccountTypeExists(int id)
        {
            AccountType? accountType = accountTypeService.GetById(id);

            if (accountType == null)
                return false;

            return true;
        }
    }
}
