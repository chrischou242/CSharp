using System;
using System.ComponentModel.DataAnnotations;

namespace Chefs_N_Dishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId{get;set;}

        [Required]
        public string NameOfDish {get;set;}
        
        [Required]
        [Range(0,Double.PositiveInfinity, ErrorMessage="Must be greater than 0")]
        public int Calories {get;set;}

        [Required]
        public string Description{get;set;}

        [Required]
        
        public int Tastiness{get;set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int ChefId {get;set;}
        //Creater will be null unless *include is 
        public Chef Creater{get;set;}

    }
}


