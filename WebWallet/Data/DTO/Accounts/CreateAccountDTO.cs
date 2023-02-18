using System.ComponentModel.DataAnnotations;

namespace WebWallet.Data.DTO.Accounts
{ 
    public class CreateAccountDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public Decimal Amount { get; set; }
        [Required]
        public string AccountNumber { get; set; }
        [Required]
        public int AccoutTypeId { get; set; }
    }
}
