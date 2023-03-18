using WebWallet.Data.DTO.Accounts;
using WebWallet.Data.DTO.AccountType;
using WebWallet.Data.DTO.Records;
using WebWallet.Data.DTO.RecordsSubcategories;
using WebWallet.Data.DTO.RecordType;

namespace WebWallet.Models.ViewModels
{
    public class AccountDetailViewModel
    {
        public List<ReadRecordDTO> Records { get; set; }
        public ReadAccountDTO Account { get; set; }
        public List<ReadAccountTypeDTO> AccountType { get; set; }
        public List<ReadRecordTypeDTO> RecordTypes { get; set; }
        public List<ReadRecordSubcategoryDTO> RecordSubcategories { get; set; }
    }
}