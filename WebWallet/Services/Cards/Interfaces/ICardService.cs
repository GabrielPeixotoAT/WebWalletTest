using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebWallet.Data.DTO.Card;
using WebWallet.Data.Result;

namespace WebWallet.Services.Cards.Interfaces
{
    public interface ICardService
    {
        Result<CreateCardDTO> Create(CreateCardDTO createCard, string userID);
        Result Delete(int id, string userID);
        List<ReadCardDTO> GetAll(string userID);
        List<ReadCardDTO> GetByBank(int bankID);
        Result<UpdateCardDTO> Update(UpdateCardDTO updateCard, string userID);
    }
}