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
    public class HomeViewModelBuilder : IViewModelBuilder
    {
        HomeViewModel viewModel;

        public HomeViewModelBuilder()
        {
            viewModel = new HomeViewModel();
        }

        public void SetAccounts(List<ReadAccountDTO> accounts)
        {
            viewModel.Accounts = accounts;
        }

        public void SetAccountTypes(List<ReadAccountTypeDTO> accountTypes)
        {
            viewModel.AccountTypes = accountTypes;
        }

        public void SetRecordCategory(List<ReadRecordCategoryDTO> recordCategories)
        {
            viewModel.Categories = recordCategories;
        }

        public void SetRecords(List<ReadRecordDTO> records)
        {
            viewModel.Records = records;
        }

        public void SetRecordSubcategory(List<ReadRecordSubcategoryDTO> recordSubcategories)
        {
            viewModel.SubCategories = recordSubcategories;
        }

        public void SetRecordTypes(List<ReadRecordTypeDTO> recordTypes)
        {
            viewModel.RecordTypes = recordTypes;
        }

        public void CalculateValues()
        {
            viewModel.CalculateCategoriesSubtotal();
            viewModel.CalculateTotalAmount();
        }

        public IViewModel GetResult()
        {
            return viewModel;
        }
    }
}