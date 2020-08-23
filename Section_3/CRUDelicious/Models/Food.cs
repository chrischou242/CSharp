using System;
using System.ComponentModel.DataAnnotations;


namespace CRUDelicious.Models
{
    public class Food
    {
        [Key]
        public int DishId{get;set;}
        [Required]
        public string NameOfDish {get;set;}
        [Required]
        public string ChefName {get;set;}
        [Required]
        [Range(0,Double.PositiveInfinity, ErrorMessage="Must be greater than 0")]

        public int Calories{get;set;}

        [Required]
        [Range(0,5, ErrorMessage="Must be between 1 and 5")]
        public int Tastiness {get;set;}

        [Required]
        public string Description{get;set;}
    }
}