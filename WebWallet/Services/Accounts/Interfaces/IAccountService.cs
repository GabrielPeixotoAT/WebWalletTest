using WebWallet.Data.DTO.Accounts;
using WebWallet.Data.Result;
using WebWallet.Models.Accounts;

namespace WebWallet.Services.Accounts.Interfaces
{
    public interface IAccountService
    {
        Result<CreateAccountDTO> Create(CreateAccountDTO createAccoutDTO);
        Result<UpdateAccountDTO> Update(UpdateAccountDTO updateAccountDTO);
        Result Delete(int id, string userID);
        List<ReadAccountDTO> GetAll(string userId);
        Account? GetByID(int id);
        ReadAccountDTO? ReadByID(int id, string userId);
    }
}