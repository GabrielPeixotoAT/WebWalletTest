using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebWallet.Data.DTO.Accounts;
using WebWallet.Data.DTO.AccountType;
using WebWallet.Data.DTO.RecordCategory;
using WebWallet.Data.DTO.Records;
using WebWallet.Data.DTO.RecordsSubcategories;
using WebWallet.Data.DTO.RecordType;

namespace WebWallet.Models.ViewModels.Builders
{
    public interface IViewModelBuilder
    {
        void SetAccounts(List<ReadAccountDTO> accounts);
        void SetAccountTypes(List<ReadAccountTypeDTO> accountTypes);
        void SetRecords(List<ReadRecordDTO> records);
        void SetRecordTypes(List<ReadRecordTypeDTO> recordTypes);
        void SetRecordCategory(List<ReadRecordCategoryDTO> recordCategories);
        void SetRecordSubcategory(List<ReadRecordSubcategoryDTO> recordSubcategories);
        void CalculateValues();
        IViewModel GetResult();
    }
}