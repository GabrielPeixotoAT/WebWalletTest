using System.ComponentModel.DataAnnotations;

namespace WebWallet.Data.DTO.Bank
{
    public class ReadBankDTO
    {
        [Required]
        public int BankID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string UserID { get; set; }
    }
}
