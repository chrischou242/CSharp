using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Collections.Generic;

namespace Bank_Accounts.Models
{
    public class Transcations
    {
        [Key]
        public int TransactionId {get;set;}
        [Required]
        public decimal Amount{get;set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int UserId {get;set;}
        public User Creater {get;set;}
    }
}

