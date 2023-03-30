using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebWallet.Data.DTO.RecordCategory
{
    public class ReadRecordCategoryDTO
    {
        [Required]
        public int RecordCategoryID { get; set; }
        [Required]
        [StringLength(50)]
        public string Description { get; set; }
    }
}