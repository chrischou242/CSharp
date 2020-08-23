using System;
using System.ComponentModel.DataAnnotations;

namespace Dojo_Survey_Validation.Models

{
    public class Survey
    {
        [Required]
        [MinLength(3)]
        public string FirstName{get;set;}


        [Required]
        public string Location {get;set;}

        [Required]
      
        public string Language {get;set;}

        [Required]
        [MinLength(3)]
        public string Comment{get;set;}
    }

}