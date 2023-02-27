using WebWallet.Data.DTO.Accounts;
using WebWallet.Data.DTO.Records;
using WebWallet.Data.DTO.RecordsSubcategories;

namespace WebWallet.Models.ViewModels
{
    public class HomeViewModel
    {
        public List<ReadAccountDTO> Accounts { get; set; }
        public List<ReadRecordDTO> Records { get; set; }
        public List<ReadRecordSubcategoryDTO> Categories { get; set; }
    }
}
