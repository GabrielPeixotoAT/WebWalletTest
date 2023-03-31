using System.ComponentModel.DataAnnotations;

namespace WebWallet.Data.DTO.RecordsSubcategories
{
    public class ReadRecordSubcategoryDTO
    {
        [Required]
        public int RecordSubcategoryID { get; set; }
        [Required]
        public int RecordCategoryID { get; set; }
        [Required]
        [StringLength(100)]
        public string Description { get; set; }
        public Decimal SubTotal { get; set; }
    }
}
