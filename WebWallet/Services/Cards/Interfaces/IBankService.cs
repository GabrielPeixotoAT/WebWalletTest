using WebWallet.Data.DTO.Bank;
using WebWallet.Data.Result;
using WebWallet.Models.Cards;

namespace WebWallet.Services.Cards.Interfaces
{
    public interface IBankService
    {
        Result<CreateBankDTO> Create(CreateBankDTO createBankDTO);
        Result Delete(int id, string userID);
        List<ReadBankDTO> GetAll(string userID);
        Result<UpdateBankDTO> Update(UpdateBankDTO updateBankDTO);
        Bank? GetByID(int id, string userID);
        ReadBankDTO ReadByID(int id, string userID);
    }
}