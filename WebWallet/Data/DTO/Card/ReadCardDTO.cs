﻿using System.ComponentModel.DataAnnotations;

namespace WebWallet.Data.DTO.Card
{
    public class ReadCardDTO
    {
        [Required]
        public int CardID { get; set; }
        [Required]
        public string Number { get; set; }
        [Required]
        public int BankID { get; set; }
        [Required]
        public DateTime ExpiringDate { get; set; }
        [Required]
        public Decimal Limit { get; set; }
        [Required]
        public string InvoicesDueDate { get; set; }
    }
}