using WebWallet.Data.DTO.AccountType;
using WebWallet.Models.Accounts;

namespace WebWallet.Services.Accounts.Interfaces
{
    public interface IAccountTypeService
    {
        AccountType? GetById(int id);
        List<ReadAccountTypeDTO> GetAll();
    }
}