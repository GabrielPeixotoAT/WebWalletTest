using System.ComponentModel.DataAnnotations;

namespace WebWallet.Data.DTO.Accounts
{
    public class ReadAccountDTO
    {
        [Required]
        public int AccountID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Decimal Amount { get; set; }
        public string? AccountNumber { get; set; }
        [Required]
        public int AccountTypeID { get; set; }
        [Required]
        [StringLength(7)]
        public string ColorCode { get; set; }
    }
}
