using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Collections.Generic;

namespace Bank_Accounts.Models
{
    public class User
    {
        
        [Key] 
        public int UserId { get; set; }
 
        [Required(ErrorMessage = "is required")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2, ErrorMessage ="Must be atleast 2 characters")]
        [Display(Name="Last Name")]

        public string LastName{get;set;}

        [Required(ErrorMessage = "is required")]
        [EmailAddress]
        public string Email {get;set;}

        [Required]
        [MinLength(8, ErrorMessage ="must be atleast 8 characters")]
        [DataType(DataType.Password)]
        public string Password{get;set;}
        
        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Doesnt match password")]
        [Display(Name="Confirm Password")]
        public string PasswordConfirm {get;set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<Transcations> Transcations {get;set;}
        

    }
}