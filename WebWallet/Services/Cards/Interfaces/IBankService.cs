using WebWallet.Data.DTO.Bank;
using WebWallet.Data.Result;

namespace WebWallet.Services.Cards.Interfaces
{
    public interface IBankService
    {
        Result<CreateBankDTO> Create(CreateBankDTO createBankDTO);
        Result Delete(int id, string userID);
        List<ReadBankDTO> ReadAll(string userID);
        Result<UpdateBankDTO> Update(UpdateBankDTO updateBankDTO);
    }
}