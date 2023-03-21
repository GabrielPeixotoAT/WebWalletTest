using System.ComponentModel.DataAnnotations;

namespace WebWallet.Data.DTO.Accounts
{
    public class UpdateAccountDTO
    {
        [Required]
        public int AccountID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Decimal Amount { get; set; }
        [Required]
        public string AccountNumber { get; set; }
        [Required]
        public int AccountTypeID { get; set; }
    }
}