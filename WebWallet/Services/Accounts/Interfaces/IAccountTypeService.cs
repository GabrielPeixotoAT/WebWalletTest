using WebWallet.Models.Accounts;

namespace WebWallet.Services.Accounts.Interfaces
{
    public interface IAccountTypeService
    {
        AccountType? ReadById(int id);
    }
}