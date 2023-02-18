using Microsoft.AspNetCore.Mvc;
using WebWallet.Data.DTO.Accounts;

namespace WebWallet.Services.Accounts.Interfaces
{
    public interface IAccountService
    {
        ActionResult<CreateAccountDTO> Create(CreateAccountDTO createAccoutDTO);
    }
}