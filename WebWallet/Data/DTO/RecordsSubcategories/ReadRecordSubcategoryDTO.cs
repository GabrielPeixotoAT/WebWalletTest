using System.ComponentModel.DataAnnotations;

namespace WebWallet.Data.DTO.RecordsSubcategories
{
    public class ReadRecordSubcategoryDTO
    {
        [Required]
        public int RecordSubcategoryId { get; set; }
        [Required]
        [StringLength(100)]
        public string Description { get; set; }
    }
}
