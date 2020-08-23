using System;
using System.ComponentModel.DataAnnotations;
namespace Form_Submissions.Models
{
    public class Login
    {   
        [Required]
        
        public string FirstName{get;set;}

        [Required]
        
        public string LastName{get;set;}

        [Required]
        public int Age{get;set;}

        [EmailAddress]
        
        public string Email{get;set;}
        [Required]
        
        public string Password{get;set;}
    }
}