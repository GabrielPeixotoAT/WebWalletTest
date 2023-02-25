using Microsoft.AspNetCore.Mvc;
using WebWallet.Data.DTO.Accounts;
using WebWallet.Data.Result;
using WebWallet.Models.Accounts;

namespace WebWallet.Services.Accounts.Interfaces
{
    public interface IAccountService
    {
        ActionResult<CreateAccountDTO> Create(CreateAccountDTO createAccoutDTO);
        Result<UpdateAccountDTO> Update(UpdateAccountDTO updateAccountDTO);
        bool Delete(int id);
        List<ReadAccountDTO> GetAll();
        Account GetByID(int id);
    }
}