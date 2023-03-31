using WebWallet.Data.DTO.Accounts;
using WebWallet.Data.DTO.AccountType;
using WebWallet.Data.DTO.RecordCategory;
using WebWallet.Data.DTO.Records;
using WebWallet.Data.DTO.RecordsSubcategories;
using WebWallet.Data.DTO.RecordType;

namespace WebWallet.Models.ViewModels
{
    public class HomeViewModel : IViewModel
    {
        public List<ReadAccountDTO> Accounts { get; set; }
        public List<ReadAccountTypeDTO> AccountTypes { get; set; }
        public List<ReadRecordDTO> Records { get; set; }
        public List<ReadRecordTypeDTO> RecordTypes { get; set; }
        public List<ReadRecordCategoryDTO> Categories { get; set; }
        public List<ReadRecordSubcategoryDTO> SubCategories { get; set; }
        public Decimal TotalAmount { get; set; } = 0;

        public void CalculateTotalAmount()
        {
            foreach(ReadAccountDTO account in Accounts)
            {
                TotalAmount += account.Amount;
            }
        }

        public void CalculateCategoriesSubtotal()
        {
            foreach(ReadRecordSubcategoryDTO subcategory in SubCategories)
            {
                subcategory.SubTotal = CalculateSubTotal(subcategory.RecordSubcategoryID);
            }
        }

        public Decimal CalculateSubTotal(int categoryId)
        {
            Decimal subTotal = 0m;

            foreach (ReadRecordDTO record in Records)
            {
                if (record.RecordSubcategoryID == categoryId && record.RecordTypeID == 1)
                {
                    subTotal += record.Value;
                }
            }

            return subTotal;
        }
    }
}
