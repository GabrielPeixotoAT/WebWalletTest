using WebWallet.Data.DTO.Bank;
using WebWallet.Data.DTO.Card;

namespace WebWallet.Models.ViewModels
{
    public class CardViewModel
    {
        public List<ReadBankDTO> Banks { get; set; }
        public List<ReadCardDTO> Cards { get; set; }
    }
}
