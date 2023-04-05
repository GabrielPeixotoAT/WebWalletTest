﻿using System.ComponentModel.DataAnnotations;

namespace WebWallet.Data.DTO.Card
{
    public class CreateCardDTO
    {
        [Required]
        public string Number { get; set; }
        [Required]
        public int BankID { get; set; }
        [Required]
        public DateTime ExpiringDate { get; set; }
        [Required]
        public Decimal Limit { get; set; }
        [Required]
        [StringLength(2)]
        public string InvoicesDueDate { get; set; }
    }
}
