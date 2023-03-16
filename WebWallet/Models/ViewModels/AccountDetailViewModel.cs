using WebWallet.Data.DTO.Accounts;
using WebWallet.Data.DTO.Records;

namespace WebWallet.Models.ViewModels
{
    public class AccountDetailViewModel
    {
        public List<ReadRecordDTO> Records { get; set; }
        public ReadAccountDTO Account { get; set; }
    }
}