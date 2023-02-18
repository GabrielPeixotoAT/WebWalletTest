using System.ComponentModel.DataAnnotations;

namespace WebWallet.Data.DTO.AccountType
{
    public class ReadAccountTypeDTO
    {
        [Required]
        public int AccountTypeID { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
