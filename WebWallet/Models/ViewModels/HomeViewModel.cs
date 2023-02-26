using WebWallet.Data.DTO.Accounts;
using WebWallet.Data.DTO.Records;

namespace WebWallet.Models.ViewModels
{
    public class HomeViewModel
    {
        public List<ReadAccountDTO> Accounts { get; set; }
        public List<ReadRecordDTO> Records { get; set; }
    }
}
