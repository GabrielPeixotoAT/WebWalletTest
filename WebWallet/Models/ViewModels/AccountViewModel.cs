using WebWallet.Data.DTO.Accounts;
using WebWallet.Data.DTO.AccountType;

namespace WebWallet.Models.ViewModels
{
    public class AccountViewModel
    {
        public List<ReadAccountDTO> Accounts { get; set; }
        public List<ReadAccountTypeDTO> AccountTypes { get; set; }
        public Decimal TotalAmount { get; set; }

        public AccountViewModel(List<ReadAccountDTO> accounts)
        {
            Accounts = accounts;
            CalculateTotalAmount();
        }

        void CalculateTotalAmount()
        {
            foreach (ReadAccountDTO account in Accounts)
            {
                TotalAmount += account.Amount;
            }
        }
    }
}
