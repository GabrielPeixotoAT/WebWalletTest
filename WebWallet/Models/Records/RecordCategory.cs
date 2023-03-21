using System.ComponentModel.DataAnnotations;

namespace WebWallet.Models.Records
{
    public class RecordCategory
    {
        [Key]
        [Required]
        public int RecordCategoryID { get; set; }
        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        public List<RecordSubcategory> RecordSubcategory { get; set; }
    }
}
