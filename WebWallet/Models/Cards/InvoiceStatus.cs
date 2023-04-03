using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebWallet.Models.Cards
{
    public class InvoiceStatus
    {
        [Key]
        [Required]
        public int InvoiceStatusID { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
