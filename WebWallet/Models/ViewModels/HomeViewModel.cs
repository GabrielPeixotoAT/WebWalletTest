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
            foreach(ReadRecordSubcategoryDTO category in Categories)
            {
                category.SubTotal = CalculateSubTotal(category.RecordSubcategoryId);
            }

            Categories = Categories.OrderByDescending(category => category.SubTotal).ToList();
        }

        public Decimal CalculateSubTotal(int categoryId)
        {
            Decimal subTotal = 0m;

            foreach (ReadRecordDTO record in Records)
            {
                if (record.RecordSubcategoryId == categoryId && record.RecordTypeId == 1)
                {
                    subTotal += record.Value;
                }
            }

            return subTotal;
        }
    }
}
