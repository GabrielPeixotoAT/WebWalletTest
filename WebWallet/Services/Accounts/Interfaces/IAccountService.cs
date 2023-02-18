using Microsoft.AspNetCore.Mvc;
using WebWallet.Data.DTO.Accounts;

namespace WebWallet.Services.Accounts.Interfaces
{
    public interface IAccountService
    {
        ActionResult<CreateAccoutDTO> Create(CreateAccoutDTO createAccoutDTO);
    }
}