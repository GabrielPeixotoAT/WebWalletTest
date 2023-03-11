using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebWallet.Data;
using WebWallet.Data.DTO.AccountType;
using WebWallet.Models.Accounts;
using WebWallet.Services.Accounts.Interfaces;

namespace WebWallet.Services.Accounts
{
    public class AccountTypeService : IAccountTypeService
    {
        private ApplicationDbContext context;
        private IMapper mapper;

        public AccountTypeService(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public AccountType? GetById(int id)
        {
            return context.AccountTypes.FirstOrDefault(at => at.AccountTypeID == id);
        }

        public List<ReadAccountTypeDTO> GetAll()
        {
            return mapper.Map<List<ReadAccountTypeDTO>>(context.AccountTypes);
        }
    }
}
